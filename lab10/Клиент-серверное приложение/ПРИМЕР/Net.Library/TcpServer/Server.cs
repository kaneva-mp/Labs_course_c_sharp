using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;
using System.Text.RegularExpressions;
using System.Linq;
using SomeProject.Library.Client;
using System.Runtime.Remoting.Metadata.W3cXsd2001;

namespace SomeProject.Library.Server
{
    /// <summary>
    /// Сервер
    /// </summary>
    public class Server
    {
        /// <summary>
        /// Номер файла создаваемого
        /// </summary>
        private static int fileNumber = 0;

        /// <summary>
        /// Максимальное число соединений
        /// </summary>
        private static int maxConnectionsCount = 1;

        /// <summary>
        /// Текущее число соединений
        /// </summary>
        private static int currentConnectionsCount = 0;

        /// <summary>
        /// Маска даты
        /// </summary>
        private static readonly string dateMask = "yyyy-MM-dd";

        /// <summary>
        /// Объект для конструкции lock
        /// </summary>
        private static object locker = new object();

        /// <summary>
        /// Слушатель соединений
        /// </summary>
        private TcpListener serverListener;

        /// <summary>
        /// Конструктор
        /// </summary>
        public Server()
        {
            serverListener = new TcpListener(IPAddress.Loopback, 80);
        }

        /// <summary>
        /// Деструктор
        /// </summary>
        ~Server()
        {
            TurnOffListener();
        }

        /// <summary>
        /// Функция для остановки прослушивания соединений
        /// </summary>
        /// <returns>Возвращает false, если была ошибка, иначе - true</returns>
        public bool TurnOffListener()
        {
            try
            {
                if (serverListener != null)
                    serverListener.Stop();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine("Cannot turn off listener: " + e.Message);
                return false;
            }
        }

        /// <summary>
        /// Функция для включения прослушки соединений
        /// </summary>
        /// <returns>Возвращает fasle, если была ошибка, иначе - true</returns>
        public async Task TurnOnListener()
        {
            try
            {
                if (serverListener != null)
                        serverListener.Start();

                ThreadPool.SetMaxThreads(maxConnectionsCount + 1, maxConnectionsCount + 1);
                ThreadPool.SetMinThreads(2, 2);
                Console.WriteLine("Waiting for connection...");

                bool shouldConnect = true;
                
                while (true) {
                    lock (locker)
                    {
                        shouldConnect = currentConnectionsCount < maxConnectionsCount;
                    }
                    
                    if (shouldConnect)
                    {
                        TcpClient client = serverListener.AcceptTcpClient();
                        Console.WriteLine("Connections: " + Interlocked.Increment(ref currentConnectionsCount));
                        ThreadPool.QueueUserWorkItem(new WaitCallback(Callback), client);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Cannot turn on listener: " + e.Message);
            }
        }

        /// <summary>
        /// Процедура для обработки подключения
        /// </summary>
        /// <param name="clientObject">Клиент</param>
        static void Callback(object clientObject)
        {   
            TcpClient client = (TcpClient)clientObject;
            ReceiveDataFromClient(client).Wait();
            client.Close();
            Console.WriteLine("Connections: " + Interlocked.Decrement(ref currentConnectionsCount));
        }

        /// <summary>
        /// Процедура для получения информации от клиента
        /// </summary>
        /// <param name="client">Клиент</param>
        /// <returns>Результат операции</returns>
        public async static Task<OperationResult> ReceiveDataFromClient(TcpClient client)
        {
            try
            {
                StringBuilder recievedMessage = new StringBuilder();
                byte[] typeByte = new byte[1];

                using (NetworkStream stream = client.GetStream())
                {
                    await stream.ReadAsync(typeByte, 0, typeByte.Length);

                    string type = recievedMessage.ToString();

                    if ((byte)DataType.Message == typeByte.First())
                    {
                        string resultMessage = ReceiveMessageFromClient(stream).Message;
                        return SendMessageToClient(stream, resultMessage);
                    } else if ((byte)DataType.File == typeByte.First()) {
                        
                        string resultMessage = ReceiveFileFromClient(stream).Message;
                        return SendMessageToClient(stream, resultMessage);
                    } else
                    {
                        return SendMessageToClient(stream, "Unknown data type!");
                    }
                }
            }
            catch (Exception e)
            {
                return new OperationResult(Result.Fail, e.Message);
            }
        }

        /// <summary>
        /// Функция для получения сообщения от клиента
        /// </summary>
        /// <param name="stream">Поток</param>
        /// <returns>Результат операции</returns>
        private static OperationResult ReceiveMessageFromClient(NetworkStream stream)
        {
            StringBuilder recievedMessage = new StringBuilder();

            try
            {
                byte[] data = new byte[256];

                while (stream.DataAvailable)
                {
                    int bytes = stream.Read(data, 0, data.Length);
                    recievedMessage.Append(Encoding.UTF8.GetString(data, 0, bytes));
                }

                Console.WriteLine("new message: " + recievedMessage.ToString());

                return new OperationResult(Result.OK, "Server: Message has been recieved!");
            }
            catch (Exception e)
            {
                return new OperationResult(Result.Fail, e.Message);
            }
        }

        /// <summary>
        /// Функция для получения файла от клиента
        /// </summary>
        /// <param name="stream">Поток</param>
        /// <returns>Результат операции</returns>
        private static OperationResult ReceiveFileFromClient(NetworkStream stream)
        {
            string extension = getExtensionOfFile(stream);

            string directoryName = DateTime.Now.ToString(dateMask);
            byte[] data = new byte[1];

            try
            { 
                if (!Directory.Exists(directoryName)) Directory.CreateDirectory(directoryName);

                int currentNumber = Interlocked.Increment(ref fileNumber);
                string filePath = directoryName + "\\File" + currentNumber + extension;
                
                using (FileStream fstream = new FileStream(filePath, FileMode.Create))
                {
                    do
                    {
                        int bytes = stream.Read(data, 0, data.Length);
                        fstream.Write(data, 0, bytes);
                    } while (stream.DataAvailable);
                }

                Console.WriteLine("new file: " + filePath);
                return new OperationResult(Result.OK, "Server: File has been uploaded!");
            }
            catch (Exception e)
            {
                return new OperationResult(Result.Fail, e.Message);
            }
        }

        /// <summary>
        /// Функция для получения расширения файла
        /// </summary>
        /// <param name="stream">Поток</param>
        /// <returns>Расширение файла</returns>
        private static string getExtensionOfFile(NetworkStream stream)
        {
            int extensionLength = stream.ReadByte();
            byte[] extensionBytes = new byte[extensionLength];
            stream.Read(extensionBytes, 0, extensionBytes.Length);

            return Encoding.UTF8.GetString(extensionBytes);
        }

        /// <summary>
        /// Функция для отправки сообщения клиенту
        /// </summary>
        /// <param name="stream">Поток</param>
        /// <param name="message">Сообщение клиенту</param>
        /// <returns>Результат операции</returns>
        private static OperationResult SendMessageToClient(NetworkStream stream, string message)
        {
            try
            {
                byte[] data = Encoding.UTF8.GetBytes(message);
                stream.Write(data, 0, data.Length);
            }
            catch (Exception e)
            {
                stream.Close();
                return new OperationResult(Result.Fail, e.Message);
            }

            return new OperationResult(Result.OK, "");
        }
    }
}
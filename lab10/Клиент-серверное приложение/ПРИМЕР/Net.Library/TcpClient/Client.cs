using System;
using System.Text;
using System.Net.Sockets;
using System.IO;
using System.Threading.Tasks;

namespace SomeProject.Library.Client
{
    /// <summary>
    /// Типы передаваемых данных
    /// </summary>
    public enum DataType
    {
        Message, File
    }

    /// <summary>
    /// Клиент
    /// </summary>
    public class Client
    {
        /// <summary>
        /// Клиент соединения
        /// </summary>
        public TcpClient tcpClient;

        /// <summary>
        /// Функция для обработки сообщений от сервера
        /// </summary>
        /// <param name="stream">Поток</param>
        /// <returns>Результат операции</returns>
        public OperationResult ReceiveMessageFromServer(NetworkStream stream)
        {
            try
            {
                StringBuilder recievedMessage = new StringBuilder();
                byte[] data = new byte[256];
                bool unreaded = true;

                while(unreaded)
                {
                    if (stream.DataAvailable)
                    {
                        unreaded = false;
                        int bytes = stream.Read(data, 0, data.Length);
                        recievedMessage.Append(Encoding.UTF8.GetString(data, 0, bytes));
                    }
                }

                stream.Close();

                return new OperationResult(Result.OK, recievedMessage.ToString());
            }
            catch (Exception e)
            {
                return new OperationResult(Result.Fail, e.ToString());
            }
        }

        /// <summary>
        /// Функция для отправки сообщения на сервер
        /// </summary>
        /// <param name="message">Сообщение</param>
        /// <returns>Результат операции</returns>
        public OperationResult SendMessageToServer(string message)
        {
            try
            {
                using (tcpClient = new TcpClient("127.0.0.1", 80))
                {
                    using (NetworkStream stream = tcpClient.GetStream())
                    {
                        
                        stream.WriteByte((byte)DataType.Message);
                        byte[] data = Encoding.UTF8.GetBytes(message);
                        stream.Write(data, 0, data.Length);

                        return ReceiveMessageFromServer(stream);
                    }
                }
            }
            catch (Exception e)
            {
                return new OperationResult(Result.Fail, e.Message);
            }
        }

        /// <summary>
        /// Функция для отправки файла на сервер
        /// </summary>
        /// <param name="filePath">Путь файла</param>
        /// <returns>Результат операции</returns>
        public OperationResult SendFileToServer(string filePath)
        {
            try
            {
                using (tcpClient = new TcpClient("127.0.0.1", 80))
                {
                    using (NetworkStream networkStream = tcpClient.GetStream())
                    {
                        string extension = Path.GetExtension(filePath);
                        networkStream.WriteByte((byte)DataType.File);
                        networkStream.WriteByte(Convert.ToByte(extension.Length));
                        networkStream.Write(Encoding.UTF8.GetBytes(extension), 0, extension.Length);

                        using (FileStream fileStream = new FileStream(filePath, FileMode.Open))
                        {
                            byte[] buffer = new byte[4096];
                            int length = 0;

                            do
                            {
                                length = fileStream.Read(buffer, 0, buffer.Length);
                                networkStream.Write(buffer, 0, length);
                            } while (length > 0);
                        }

                        return ReceiveMessageFromServer(networkStream);
                    }
                }
            }
            catch (Exception e)
            {
                return new OperationResult(Result.Fail, e.Message);
            }
        }
    }
}

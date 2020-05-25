using System;
using SomeProject.Library.Server;

namespace SomeProject.TcpServer
{
    class EnteringPointServer
    {
        /// <summary>
        /// Вход в программу
        /// </summary>
        /// <param name="args">Аргументы</param>
        static void Main(string[] args)
        {
           try
            {
                Server server = new Server();
                server.TurnOnListener().Wait();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}

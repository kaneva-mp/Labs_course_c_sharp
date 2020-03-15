using System;
using System.IO;

namespace Lab_2
{
    class Program
    {
        /// <summary>
        /// Название файла с параметрами изданий
        /// </summary>
        private static string readFile = "input.txt";

        /// <summary>
        /// Точка входа для приложения
        /// </summary>
        /// <param name="args"> Список аргументов командной строки</param>
        static void Main(string[] args)
        {

            StreamReader sr;
            try
            {
                sr = new StreamReader(readFile);
            }
            catch
            {
                Console.WriteLine("Can't read file");
                return;
            }

            int sourceCount;

            try
            {
                sourceCount = Int32.Parse(sr.ReadLine());
            }
            catch
            {
                Console.WriteLine("Can't get number of sources");
                return;
            }

            if (sourceCount <= 0)
            {
                Console.WriteLine("Number of sources must be bigger than zero");
                return;
            }

            Catalog catalog = new Catalog(sourceCount);

            for (int i = 0; i < sourceCount; i++)
            {
                string[] sourceArray;

                try
                {
                    sourceArray = sr.ReadLine().Split("|");
                }
                catch
                {
                    Console.WriteLine("Cannot read line " + i);
                    break;
                }
                catalog.add(sourceArray, i);
            }

            sr.Close();
            catalog.PrintAllEditionsInformation();
            Console.WriteLine("Search");
            catalog.FindEdition("author");

            catalog.serialize("xml.txt");
        }
    }
}


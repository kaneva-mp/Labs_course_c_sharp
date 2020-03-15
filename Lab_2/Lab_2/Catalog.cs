using System;
using System.Diagnostics;
using System.Xml.Serialization;
using System.IO;

namespace Lab_2
{
    public class Catalog
    {
        /// <summary>
        /// Количество изданий в каталоге
        /// </summary>
        public int editionCount;

        /// <summary>
        /// Массив изданий
        /// </summary>
        public Source[] editions;

        /// <summary>
        /// Конструктор пустого каталога
        /// </summary>
        public Catalog()
        {
            this.editionCount = 0;
            this.editions = new Source[editionCount];
        }

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="editionCount"> Количество изданий </param>
        public Catalog(int editionCount)
        {
            Trace.WriteLine("Call constructor Catalog");
            this.editionCount = editionCount;
            this.editions = new Source[editionCount];
        }

        /// <summary>
        /// Вывод информации о всех изданиях в каталоге
        /// </summary>
        public void PrintAllEditionsInformation()
        {
            Trace.WriteLine("Call PrintAllEditionsInformation");
            foreach (Source edition in editions)
            {
                if (edition is null)
                {
                    Console.WriteLine("Can't print");
                }
                else
                {
                    edition.GetInformation();
                }
            }
        }

        /// <summary>
        /// Поиск издания в каталоге по фамилии автора
        /// </summary>
        /// <param name="authorLastName"></param>
        public void FindEdition(string authorLastName)
        {
            Trace.WriteLine("Call FindEdition(authorLastName)");

            bool founded = false;

            foreach (Source edition in editions)
            {
                if (edition is null)
                {
                    Console.WriteLine("Can't print");
                    return;
                }
                else if (edition.CheckAuthor(authorLastName))
                {
                    edition.GetInformation();
                    founded = true;
                }
            }

            if (!founded)
            {
                Console.WriteLine("Can't find");
            }
        }

        /// <summary>
        /// Добавление издания в каталог
        /// </summary>
        /// <param name="details"> Массив, состоящий из пераметров издания </param>
        /// <param name="index"> Номер издания в каталоге </param>
        public void add(string[] details, int index)
        {
            Trace.WriteLine("Add edition");

            Source element = convertArrayToEdition(details);

            if (element is null)
            {
                Console.WriteLine("Data is not correct in line " + index);
            }
            else if (index > -1 && index < editionCount)
            {
                editions[index] = element;
            }
            else
            {
                Console.WriteLine("Wrong index " + index);
            }
        }

        /// <summary>
        /// Функция, преобразующая массив параметров издания к экземпляру издания
        /// </summary>
        /// <param name="details"> Массив, состоящий из параметров издания</param>
        /// <returns> Издание </returns>
        private Source convertArrayToEdition(string[] details)
        {
            Trace.Indent();
            Trace.WriteLine("Call convertArrayToEdition");
            Trace.Unindent();

            string edition = details[0].ToLower();

            switch (edition)
            {
                case "book":
                    return new Book(details[1], details[2], Convert.ToInt32(details[3]), details[4]);
                case "paper":
                    return new Paper(details[1], details[2],Convert.ToInt32(details[3]), Convert.ToInt32(details[4]));
                case "eresources":
                    return new EResources(details[1], details[2], details[3], details[4]);
                default:
                    return null;
            }
        }

        /// <summary>
        /// Функция для генерации XML-файла
        /// </summary>
        /// <param name="fileName">название файла для генерации XML</param>
        public void serialize(string fileName)
        {
            Trace.WriteLine("Call SoftwareManager method serialize() with file name: " + fileName);

            TextWriter writer = new StreamWriter(fileName, false);

            XmlSerializer serializer = new XmlSerializer(typeof(Catalog),
                new Type[] { typeof(Book), typeof(Paper), typeof(EResources) });
            serializer.Serialize(writer, this);
            writer.Close();
        }
    }
}

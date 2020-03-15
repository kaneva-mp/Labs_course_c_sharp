using System;
using System.Diagnostics;

namespace Lab_2
{
    public class Paper : Source
    {
        /// <summary>
        /// Номер выпуска
        /// </summary>
        public int releaseNumber;

        /// <summary>
        /// Год публикации
        /// </summary>
        public int yearOfPublication;

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="nameOfEdition"> Название журнала </param>
        /// <param name="authorLastName"> Фамилия автора </param>
        /// <param name="releaseNumber"> Номер выпуска </param>
        /// <param name="yearOfPublication"> Год публикации </param>
        public Paper(string nameOfEdition, string authorLastName, int releaseNumber, int yearOfPublication)
            : base(nameOfEdition, authorLastName)
        {
            Trace.Indent();
            Trace.WriteLine("Call constructor Paper");
            Trace.Unindent();

            this.releaseNumber = releaseNumber;
            this.yearOfPublication = yearOfPublication;
        }

        /// <summary>
        /// Конструктор
        /// </summary>
        public Paper()
           : base(String.Empty, String.Empty)
        {
            this.yearOfPublication = 0;
            this.releaseNumber = 0;
        }

        /// <summary>
        /// Функция вывода в консоль информацию о журнале
        /// </summary>
        public override void GetInformation()
        {
            Trace.WriteLine("Call Paper.GetInformation");

            Console.WriteLine("Edition name: {0}, Author last name: {1}, Release number: {2}, Year of publication: {3}",
                nameOfEdition, authorLastName, releaseNumber, yearOfPublication);
        }

        /// <summary>
        /// Функция, сравнивающая фамилию автора журнала с заданной фамилией
        /// </summary>
        /// <param name="authorLastName"> Фамилия автора </param>
        /// <returns> true - искомое издание, false - нет </returns>
        public override bool CheckAuthor(string authorLastName)
        {
            Trace.Indent();
            Trace.WriteLine("Call Paper.CheckAuthor");
            Trace.Unindent();

            return this.authorLastName.ToLower() == authorLastName.ToLower();
        }
    }
}

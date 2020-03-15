using System;
using System.Diagnostics;

namespace Lab_2
{
    /// <summary>
    /// Класс книги
    /// </summary>
    public class Book : Source
    {
        /// <summary>
        /// Год публикации книги
        /// </summary>
        public int yearOfPublication;
        /// <summary>
        /// Название издательства
        /// </summary>
        public string publishing;

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="nameOfEdition"> Название книги </param>
        /// <param name="authorLastName"> Фамилия автора </param>
        /// <param name="yearOfPublication"> Год публикации </param>
        /// <param name="publishing"> Название издательства  </param>
        public Book(string nameOfEdition, string authorLastName, int yearOfPublication, string publishing)
            : base(nameOfEdition, authorLastName)
        {
            Trace.Indent();
            Trace.WriteLine("Call constructor Book");
            Trace.Unindent();

            this.yearOfPublication = yearOfPublication;
            this.publishing = publishing;
        }

        /// <summary>
        /// Конструктор 
        /// </summary>
        public Book()
            : base(String.Empty, String.Empty)
        {
            this.yearOfPublication = 0;
            this.publishing = String.Empty;
        }

        /// <summary>
        /// Функция для вывода в консоль информацию о книге
        /// </summary>
        public override void GetInformation()
        {
            Trace.WriteLine("Call Book.GetInformation");

            Console.WriteLine("Edition name: {0}, Author last name: {1}, Year of publication: {2}, Publishing: {3}",
                nameOfEdition, authorLastName, yearOfPublication, publishing);
        }

        /// <summary>
        /// Функция, сравнивающая фамилию автора книги с заданной фамилией
        /// </summary>
        /// <param name="authorLastName"> Фамилия автора </param>
        /// <returns> true - искомое издание, false - нет </returns>
        public override bool CheckAuthor(string authorLastName)
        {
            Trace.Indent();
            Trace.WriteLine("Call Book.CheckAuthor");
            Trace.Unindent();

            return this.authorLastName.ToLower() == authorLastName.ToLower();
        }
    }
}

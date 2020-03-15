using System;
using System.Diagnostics;

namespace Lab_2
{
    /// <summary>
    /// Абстрактый класс источников информации
    /// </summary>
    abstract public class Source
    {
        /// <summary>
        /// Название издания
        /// </summary>
        public string nameOfEdition;

        /// <summary>
        /// Фамилия автора издания
        /// </summary>
        public string authorLastName;

        /// <summary>
        /// Конструктор класса
        /// </summary>
        /// <param name="nameOfEdition"> Название издания </param>
        /// <param name="authorLastName"> Фамилия автора </param>
        public Source(string nameOfEdition, string authorLastName)
        {
            Trace.Indent();
            Trace.WriteLine("Call constructor Source");
            Trace.Unindent();

            this.nameOfEdition = nameOfEdition;
            this.authorLastName = authorLastName;
        }

        /// <summary>
        /// Функция вывода в консоль информации об издании
        /// </summary>
        public abstract void GetInformation();

        /// <summary>
        /// Функция, сравнивающая фамилию автора издания с заданной фамилией
        /// </summary>
        /// <param name="authorLastName"> Фамилия автора </param>
        /// <returns> true - искомое издание, false - нет </returns>
        public abstract bool CheckAuthor(string authorLastName);
    }
}

using System;
using System.Diagnostics;

namespace Lab_2
{
    public class EResources : Source
    {
        /// <summary>
        /// Ссылка
        /// </summary>
        public string link;

        /// <summary>
        /// Аннотация
        /// </summary>
        public string annotation;

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="nameOfEdition"> Название статьи </param>
        /// <param name="authorLastName"> ФАмилия автора </param>
        /// <param name="link"> Ссылка </param>
        /// <param name="annotation"> Аннотация </param>
        public EResources(string nameOfEdition, string authorLastName, string link, string annotation)
            : base(nameOfEdition, authorLastName)
        {
            Trace.Indent();
            Trace.WriteLine("Call constructor EResources");
            Trace.Unindent();

            this.link = link;
            this.annotation = annotation;
        }

        /// <summary>
        /// Конструктор
        /// </summary>
        public EResources()
           : base(String.Empty, String.Empty)
        {
            this.link = String.Empty;
            this.annotation = String.Empty;
        }

        /// <summary>
        /// Функция вывода в консоль информацию о статье
        /// </summary>
        public override void GetInformation()
        {
            Trace.WriteLine("Call EResources.GetInformation");

            Console.WriteLine("Edition name: {0}, Author last name: {1}, Link: {2}, Annotation: {3}",
                nameOfEdition, authorLastName, link, annotation);
        }

        /// <summary>
        /// Функция, сравнивающая фамилию автора статьи с заданной фамилией
        /// </summary>
        /// <param name="authorLastName"> Фамилия автора </param>
        /// <returns> true - искомое издание, false - нет </returns>
        public override bool CheckAuthor(string authorLastName)
        {
            Trace.Indent();
            Trace.WriteLine("Call EResiurces.CheckAuthor");
            Trace.Unindent();

            return this.authorLastName.ToLower() == authorLastName.ToLower();
        }
    }
}

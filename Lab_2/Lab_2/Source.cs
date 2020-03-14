using System;
namespace Lab_2
{
    abstract public class Source
    {
        public string nameOfEdition;
        public string authorLastName;

        public Source(string nameOfEdition, string authorLastName)
        {
            this.nameOfEdition = nameOfEdition;
            this.authorLastName = authorLastName;
        }

        public abstract void GetInformation();

        public abstract bool CheckAuthor(string authorLastName);
    }
}

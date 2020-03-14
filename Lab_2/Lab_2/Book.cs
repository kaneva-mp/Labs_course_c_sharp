using System;
namespace Lab_2
{
    public class Book : Source
    {
        public int yearOfPublication;
        public string publishing;


        public Book(string nameOfEdition, string authorLastName, int yearOfPublication, string publishing)
            : base(nameOfEdition, authorLastName)
        {
            this.yearOfPublication = yearOfPublication;
            this.publishing = publishing;
        }

        public override void GetInformation()
        {
            Console.WriteLine("Edition name: {0}, Author last name: {1}, Year of publication: {2}, Publishing: {3}",
                nameOfEdition, authorLastName, yearOfPublication, publishing);
        }

        public override bool CheckAuthor(string authorLastName)
        {
            return this.authorLastName.ToLower() == authorLastName.ToLower();
        }
    }
}

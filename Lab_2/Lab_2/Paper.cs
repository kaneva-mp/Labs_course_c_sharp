using System;
namespace Lab_2
{
    public class Paper : Source
    {
        public int releaseNumber;
        public int yearOfPublication;

        public Paper(string nameOfEdition, string authorLastName, int releaseNumber, int yearOfPublication)
            : base(nameOfEdition, authorLastName)
        {
            this.releaseNumber = releaseNumber;
            this.yearOfPublication = yearOfPublication;
        }

        public override void GetInformation()
        {
            Console.WriteLine("Edition name: {0}, Author last name: {1}, Release number: {2}, Year of publication: {3}",
                nameOfEdition, authorLastName, releaseNumber, yearOfPublication);
        }

        public override bool CheckAuthor(string authorLastName)
        {
            return this.authorLastName.ToLower() == authorLastName.ToLower();
        }
    }
}

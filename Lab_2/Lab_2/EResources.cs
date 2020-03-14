using System;
namespace Lab_2
{
    public class EResources : Source
    {
        public string link;
        public string annotation;

        public EResources(string nameOfEdition, string authorLastName, string link, string annotation)
            : base(nameOfEdition, authorLastName)
        {
            this.link = link;
            this.annotation = annotation;
        }

        public override void GetInformation()
        {
            Console.WriteLine("Edition name: {0}, Author last name: {1}, Link: {2}, Annotation: {3}",
                nameOfEdition, authorLastName, link, annotation);
        }

        public override bool CheckAuthor(string authorLastName)
        {
            return this.authorLastName.ToLower() == authorLastName.ToLower();
        }
    }
}

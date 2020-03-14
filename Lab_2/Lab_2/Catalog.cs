using System;
namespace Lab_2
{
    public class Catalog
    {
        public int editionCount;
        public Source[] editions;

        public Catalog()
        {
            this.editionCount = 0;
            this.editions = new Source[editionCount];
        }

        public Catalog(int editionCount)
        {
            this.editionCount = editionCount;
            this.editions = new Source[editionCount];
        }

        public void PrintAllEditionsInformation()
        {
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

        public void FindEdition(string authorLastName)
        {
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

        public void add(string[] details, int index)
        {

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

        private Source convertArrayToEdition(string[] details)
        {
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

    }
}

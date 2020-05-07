using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using lab_8;
using System.Xml.Linq;
using System.IO;

namespace UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void EmptyPathXMLFileInput()
        {
            Form1 form = new Form1();

            form.parseXML(String.Empty);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void EmptyXMLFile()
        {
            Form1 form = new Form1();
            string fileName = "Test.xml";

            XDocument doc = new XDocument(new XElement("record"));
            doc.Save(fileName);
            File.WriteAllText(fileName, String.Empty);

            form.parseXML(fileName);
        }

        [TestMethod]
        public void CorrectXMLFileInput()
        {
            Form1 form = new Form1();
            string fileName = "Test.xml";

            XDocument doc = new XDocument(
                new XElement("records",
                    new XElement("record",
                        new XElement("houseNumber", 123),
                        new XElement("apartNumber", 23),
                        new XElement("lastname", "Masha"),
                        new XElement("paymentType", "квартплата"),
                        new XElement("paymentSum", 34.2),
                        new XElement("paymentDate", "24.01.2020"),
                        new XElement("pennyPercent", 0.33),
                        new XElement("paymentDaysLeft", 34))));
            doc.Save(fileName);

            form.parseXML(fileName);
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void IncorrectXMLFileInput()
        {
            Form1 form = new Form1();
            string fileName = "Test.xml";

            XDocument doc = new XDocument(
                new XElement("records",
                    new XElement("record",
                        new XElement("houseNumber", "234fd3"),
                        new XElement("apartNumber", 23),
                        new XElement("lastname", "Masha"),
                        new XElement("paymentType", "test"),
                        new XElement("paymentSum", 34.2),
                        new XElement("paymentDate", "24.01.2020"),
                        new XElement("pennyPercent", 4.33),
                        new XElement("paymentDaysLeft", 34))));
            doc.Save(fileName);

            form.parseXML(fileName);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void UnknownFormat()
        {
            Form1 form = new Form1();
            form.parseXML("test.txt");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NullValue_addRecordToXml()
        {
            Form1 form = new Form1();

            PaymentRecord record = new PaymentRecord("12", null, "Masha", null, null, null, null, null);

            form.addRecordToXml("Test.xml", record);

        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void NullPath_addRecordToXml()
        {
            Form1 form = new Form1();
            PaymentRecord record = new PaymentRecord("1", "23", "Masha", "квартплата", "24.01.2020", "23.2", "0.23", "12");
            form.addRecordToXml(null, record);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void UncorrectPath_removeRecordFromXML()
        {
            Form1 form = new Form1();

            PaymentRecord record = new PaymentRecord("1", "23", "Masha", "квартплата", "24.01.2020", "23.2", "0.23", "12");
            form.removeRecordFromXML("unknown.xml", record);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void NullElement_removeRecordFromXML()
        {
            Form1 form = new Form1();
            form.removeRecordFromXML("file.xml", null);
        }

        [TestMethod]
        public void CorrectOutput_addRecordToXml()
        {
            Form1 form = new Form1();
            string fileName = "Test.xml";

            XDocument doc = new XDocument(
                new XElement("records",
                    new XElement("record",
                        new XElement("houseNumber", 123),
                        new XElement("apartNumber", 23),
                        new XElement("lastname", "Masha"),
                        new XElement("paymentType", "квартплата"),
                        new XElement("paymentSum", 34.2),
                        new XElement("paymentDate", "24.01.2020"),
                        new XElement("pennyPercent", 0.33),
                        new XElement("paymentDaysLeft", 34))));
            doc.Save(fileName);

            PaymentRecord record = new PaymentRecord("19", "23", "Masha", "квартплата", "24.01.2020", "23.2", "0.23", "12");

            form.addRecordToXml(fileName, record);
        }
    }
}


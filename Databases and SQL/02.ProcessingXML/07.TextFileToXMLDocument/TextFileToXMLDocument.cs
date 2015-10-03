namespace _07.TextFileToXMLDocument
{
    using System;
    using System.IO;
    using System.Xml.Linq;

    public static class TextFileToXMLDocument
    {
        public static void Main()
        {
            Person person = new Person();

            StreamReader reader = new StreamReader("../../personInfo.txt");

            using (reader)
            {
                person.Name = reader.ReadLine();
                person.Address = reader.ReadLine();
                person.Phone = reader.ReadLine();
            }

            XElement personElement = new XElement(
                "person",
                new XElement("name", person.Name),
                new XElement("address", person.Address),
                new XElement("phone", person.Phone));

            personElement.Save("../../personInXML.xml");
            Console.WriteLine("New .xml file has been created");
        }
    }
}
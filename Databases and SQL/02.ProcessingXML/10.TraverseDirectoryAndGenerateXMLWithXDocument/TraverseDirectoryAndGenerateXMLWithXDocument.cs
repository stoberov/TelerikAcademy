namespace _10.TraverseDirectoryAndGenerateXMLWithXDocument
{
    using System;
    using System.IO;
    using System.Xml.Linq;

    public static class TraverseDirectoryAndGenerateXMLWithXDocument
    {
        public static void Main()
        {
            string directory =
                "D:\\SkyDrive\\Telerik Academy\\Databases and SQL\\Homework\\02.ProcessingXML\\09.TraverseDirectoryAndGenerateXMLWithXmlWriter";

            DirectoryInfo rootDirectory = new DirectoryInfo(directory);
            XElement directoryList = new XElement("root");

            directoryList.Add(TraverseDirectory(rootDirectory));

            directoryList.Save("../../directoryList.xml");

            Console.WriteLine("New .xml file has been created");
        }

        private static XElement TraverseDirectory(DirectoryInfo directory)
        {
            XElement element = new XElement("dir", new XAttribute("path", directory.Name));

            foreach (DirectoryInfo dir in directory.GetDirectories())
            {
                element.Add(TraverseDirectory(dir));
            }

            foreach (FileInfo file in directory.GetFiles())
            {
                element.Add(new XElement("file", new XAttribute("name", file.Name)));
            }

            return element;
        }
    }
}
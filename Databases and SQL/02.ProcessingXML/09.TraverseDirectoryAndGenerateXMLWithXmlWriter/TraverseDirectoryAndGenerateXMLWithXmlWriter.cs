namespace _09.TraverseDirectoryAndGenerateXMLWithXmlWriter
{
    using System;
    using System.IO;
    using System.Text;
    using System.Xml;

    public static class TraverseDirectoryAndGenerateXMLWithXmlWriter
    {
        public static void Main()
        {
            string directory =
                "D:\\SkyDrive\\Telerik Academy\\Databases and SQL\\Homework\\02.ProcessingXML\\09.TraverseDirectoryAndGenerateXMLWithXmlWriter";
            string fileName = "../../directoryList.xml";
            Encoding encoding = Encoding.GetEncoding("windows-1251");

            DirectoryInfo rootDirectory = new DirectoryInfo(directory);

            XmlTextWriter writer = new XmlTextWriter(fileName, encoding);

            using (writer)
            {
                writer.Formatting = Formatting.Indented;
                writer.IndentChar = '\t';
                writer.Indentation = 1;

                writer.WriteStartDocument();
                writer.WriteStartElement("root");

                TraverseDirectory(writer, rootDirectory);

                writer.WriteEndDocument();
            }

            Console.WriteLine("New .xml file has been created");
        }

        private static void TraverseDirectory(XmlTextWriter writer, DirectoryInfo directory)
        {
            foreach (DirectoryInfo dir in directory.GetDirectories())
            {
                writer.WriteStartElement("dir");
                writer.WriteAttributeString("path", dir.Name);

                TraverseDirectory(writer, dir);
            }

            foreach (FileInfo file in directory.GetFiles())
            {
                writer.WriteStartElement("file");
                writer.WriteAttributeString("name", file.Name);
                writer.WriteEndElement();
            }

            writer.WriteEndElement();
        }
    }
}
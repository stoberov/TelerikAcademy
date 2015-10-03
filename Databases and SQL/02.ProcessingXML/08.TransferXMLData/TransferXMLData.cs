namespace _08.TransferXMLData
{
    using System;
    using System.Text;
    using System.Xml;

    public static class TransferXMLData
    {
        public static void Main()
        {
            string fileName = "../../album.xml";
            Encoding encoding = Encoding.GetEncoding("windows-1251");
            XmlTextWriter writer = new XmlTextWriter(fileName, encoding);

            using (writer)
            {
                writer.Formatting = Formatting.Indented;
                writer.IndentChar = '\t';
                writer.Indentation = 1;

                writer.WriteStartDocument();
                writer.WriteStartElement("catalog");

                XmlReader reader = XmlReader.Create("../../catalog.xml");

                using (reader)
                {
                    while (reader.Read())
                    {
                        if (reader.NodeType == XmlNodeType.Element && (reader.Name == "name"))
                        {
                            writer.WriteStartElement("album");
                            writer.WriteElementString("name", reader.ReadElementString());
                        }
                        else if (reader.NodeType == XmlNodeType.Element && (reader.Name == "artist"))
                        {
                            writer.WriteElementString("artist", reader.ReadElementString());
                            writer.WriteEndElement();
                        }
                    }
                }

                writer.WriteEndDocument();
            }

            Console.WriteLine("New .xml file has been created");
        }
    }
}
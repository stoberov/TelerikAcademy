namespace _05.ExtractSongTitlesWithXmlReader
{
    using System;
    using System.Xml;

    public static class ExtractSongTitlesWithXmlReader
    {
        public static void Main()
        {
            Console.WriteLine("Songs in Catalog:");
            Console.WriteLine("-----------------");

            XmlReader reader = XmlReader.Create("../../catalog.xml");

            using (reader)
            {
                int songNumber = 1;

                while (reader.Read())
                {
                    if ((reader.NodeType == XmlNodeType.Element) &&
                        (reader.Name == "title"))
                    {
                        Console.WriteLine(songNumber + "." + reader.ReadElementString());
                        songNumber++;
                    }
                }
            }
        }
    }
}
namespace _03.ExtractUniqueArtistsWithXPath
{
    using System;
    using System.Collections.Generic;
    using System.Xml;

    public static class ExtractUniqueArtistsWithXPath
    {
        public static void Main()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("../../catalog.xml");

            XmlNode rootNode = doc.DocumentElement;
            string xPathQuery = "/catalog/album/artist";

            if (rootNode != null)
            {
                XmlNodeList aristsList = rootNode.SelectNodes(xPathQuery);

                var uniqueArtistsInfo = new Dictionary<string, int>();

                if (aristsList != null)
                {
                    foreach (XmlNode node in aristsList)
                    {
                        string currentArtist = node.InnerText;

                        if (uniqueArtistsInfo.ContainsKey(currentArtist))
                        {
                            uniqueArtistsInfo[currentArtist]++;
                        }
                        else
                        {
                            uniqueArtistsInfo.Add(currentArtist, 1);
                        }
                    }
                }

                foreach (var artist in uniqueArtistsInfo)
                {
                    Console.WriteLine("{0} has {1} albums.", artist.Key, artist.Value);
                }
            }
        }
    }
}
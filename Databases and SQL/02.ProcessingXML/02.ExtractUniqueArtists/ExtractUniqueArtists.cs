namespace _02.ExtractUniqueArtists
{
    using System;
    using System.Collections.Generic;
    using System.Xml;

    public static class ExtractUniqueArtists
    {
        public static void Main()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("../../catalog.xml");

            XmlNode rootNode = doc.DocumentElement;

            if (rootNode != null)
            {
                var uniqueArtistsInfo = new Dictionary<string, int>();

                foreach (XmlNode node in rootNode)
                {
                    string currentArist = node["artist"].InnerText;

                    if (uniqueArtistsInfo.ContainsKey(currentArist))
                    {
                        uniqueArtistsInfo[currentArist]++;
                    }
                    else
                    {
                        uniqueArtistsInfo.Add(node["artist"].InnerText, 1);
                    }
                }

                foreach (var artist in uniqueArtistsInfo)
                {
                    Console.WriteLine("{0} has {1} albums", artist.Key, artist.Value);
                }
            }
        }
    }
}
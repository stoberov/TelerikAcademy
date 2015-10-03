namespace _11.ExtractPricesOfOldAlbums
{
    using System;
    using System.Xml;

    public static class ExtractPricesOfOldAlbums
    {
        public static void Main()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("../../catalog.xml");

            XmlNode rootNode = doc.DocumentElement;
            string xPathQuery = "/catalog/album[year<2010]/price";

            if (rootNode != null)
            {
                XmlNodeList albumPrices = rootNode.SelectNodes(xPathQuery);

                foreach (XmlNode currentAlbumPrice in albumPrices)
                {
                    Console.WriteLine(currentAlbumPrice.ParentNode.FirstChild.InnerText);
                    Console.WriteLine(currentAlbumPrice.InnerText);
                    Console.WriteLine("----------");
                }
            }
        }
    }
}
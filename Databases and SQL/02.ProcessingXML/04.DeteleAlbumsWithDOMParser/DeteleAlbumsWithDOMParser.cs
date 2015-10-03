namespace _04.DeteleAlbumsWithDOMParser
{
    using System;
    using System.Xml;

    public static class DeteleAlbumsWithDOMParser
    {
        public static void Main()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("../../catalog.xml");

            XmlNode rootNode = doc.DocumentElement;

            if (rootNode != null)
            {
                foreach (XmlNode node in rootNode.SelectNodes("album"))
                {
                    double currentAlbumPrice = double.Parse(node["price"].InnerText);

                    if (currentAlbumPrice > 20)
                    {
                        rootNode.RemoveChild(node);
                    }
                }
            }

            doc.Save("../../catalogWithRemovedAlbums.xml");
            Console.WriteLine("New .xml file has been created");
        }
    }
}
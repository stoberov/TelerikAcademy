namespace _06.ExtractSongTitlesWithXDocumentAndLINQ
{
    using System;
    using System.Linq;
    using System.Xml.Linq;

    public static class ExtractSongTitlesWithXDocumentAndLINQ
    {
        public static void Main()
        {
            XDocument xmlDoc = XDocument.Load("../../catalog.xml");

            var songs =
                from song in xmlDoc.Descendants("song")
                select new
                {
                    Title = song.Element("title").Value
                };

            int songNumber = 1;

            Console.WriteLine("Songs in Catalog:");
            Console.WriteLine("-----------------");

            foreach (var song in songs)
            {
                Console.WriteLine(songNumber + "." + song.Title);
                songNumber++;
            }
        }
    }
}
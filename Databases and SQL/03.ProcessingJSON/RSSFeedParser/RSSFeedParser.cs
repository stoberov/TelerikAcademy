namespace RSSFeedParser
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Xml.Linq;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public static class RSSFeedParser
    {
        public static void Main()
        {
            // Download the RSS feed and save locally as XML
            string rssLocationURL = "https://www.youtube.com/feeds/videos.xml?channel_id=UCLC-vbm7OWvpbqzXaoAMGGw";
            string localFile = "../../rssContent.xml";

            var client = new WebClient();
            client.DownloadFile(rssLocationURL, localFile);

            // XML to JSON
            var xmlFeed = XDocument.Load(localFile);
            string jsonFeed = JsonConvert.SerializeXNode(xmlFeed, Formatting.Indented);
            // Console.WriteLine(jsonFeed);

            // Get the titles
            var jsonObj = JObject.Parse(jsonFeed);
            var titles = jsonObj["feed"]["entry"].Select(t => t["title"]);
            // Console.WriteLine(string.Join(Environment.NewLine, titles));

            // Get the videos
            var videos = jsonObj["feed"]["entry"].Select(v => JsonConvert.DeserializeObject<Video>(v.ToString()));

            // Generate HTML
            string htmlPage = GenerateHtml(videos);

            File.WriteAllText("../../videos.html", htmlPage, Encoding.UTF8);

            Console.WriteLine("HTML file generated.");
        }

        private static string GenerateHtml(IEnumerable<Video> items)
        {
            var sb = new StringBuilder();

            sb.AppendLine("<!DOCTYPE html>");
            sb.AppendLine("<html>");
            sb.AppendLine("<body>");
            sb.AppendLine("<ul>");

            foreach (var item in items)
            {
                sb.AppendFormat("<li style=\"list-style-type:none;\">");
                sb.AppendFormat("<a href=\"{0}\">{1}</a>", item.Link.Href, item.Title);
                sb.AppendFormat("</li>");
                sb.AppendFormat("<iframe src=\"http://www.youtube.com/embed/{0}\"></iframe>", item.Id);
            }

            sb.AppendLine("</ul>");
            sb.AppendLine("</body>");
            sb.AppendLine("</html>");

            return sb.ToString();
        }
    }
}
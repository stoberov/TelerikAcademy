namespace RSSFeedParser
{
    using Newtonsoft.Json;

    public class Link
    {
        [JsonProperty("@href")]
        public string Href { get; set; }
    }
}
using Newtonsoft.Json;

namespace Pubg.Net
{
    public class PubgAsset
    {
        [JsonProperty]
        public string Id { get; set; }

        [JsonProperty]
        public string TitleId { get; set; }

        [JsonProperty]
        public string ShardId { get; set; }

        [JsonProperty]
        public string Name { get; set; }

        [JsonProperty]
        public string CreatedAt { get; set; }

        [JsonProperty]
        public string Filename { get; set; }

        [JsonProperty]
        public string ContentType { get; set; }

        [JsonProperty]
        public string Url { get; set; }
    }
}

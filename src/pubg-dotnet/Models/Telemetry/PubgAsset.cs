using Newtonsoft.Json;
using Pubg.Net.Models.Base;

namespace Pubg.Net
{
    public class PubgAsset : PubgShardedEntity
    {
        [JsonProperty]
        public string TitleId { get; set; }

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

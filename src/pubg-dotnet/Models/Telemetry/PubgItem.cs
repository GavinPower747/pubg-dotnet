using Newtonsoft.Json;

namespace Pubg.Net.Models.Telemetry
{
    public class PubgItem
    {
        [JsonProperty]
        public string ItemId { get; set; }

        [JsonProperty]
        public int StackCount { get; set; }

        [JsonProperty]
        public string Category { get; set; }

        [JsonProperty]
        public string SubCategory { get; set; }

        [JsonProperty]
        public string[] AttachedItems { get; set; }
    }
}

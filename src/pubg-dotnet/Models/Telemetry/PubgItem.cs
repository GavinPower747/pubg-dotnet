using Newtonsoft.Json;
using Pubg.Net.Models.Telemetry.Enums;

namespace Pubg.Net
{
    public class PubgItem
    {
        [JsonProperty]
        public string ItemId { get; set; }

        [JsonProperty]
        public int StackCount { get; set; }

        [JsonProperty]
        public PubgItemCategory Category { get; set; }

        [JsonProperty]
        public PubgItemSubCategory SubCategory { get; set; }

        [JsonProperty]
        public string[] AttachedItems { get; set; }
    }
}

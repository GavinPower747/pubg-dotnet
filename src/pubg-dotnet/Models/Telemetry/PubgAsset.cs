using Newtonsoft.Json;
using Pubg.Net.Models.Base;
using System;

namespace Pubg.Net
{
    public class PubgAsset : PubgEntity
    {
        [JsonProperty]
        public DateTime CreatedAt { get; set; }

        [JsonProperty]
        public string Url { get; set; }

        [JsonProperty]
        public string Description { get; set; }

        [JsonProperty]
        public string Name { get; set; }
    }
}

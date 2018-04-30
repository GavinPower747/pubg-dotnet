using Newtonsoft.Json;
using Pubg.Net.Models.Base;
using System.Collections.Generic;

namespace Pubg.Net
{
    public class PubgSeason : PubgEntity
    {
        [JsonProperty]
        public bool IsCurrentSeason { get; set; }

        [JsonProperty]
        public bool IsOffseason { get; set; }

        [JsonProperty]
        public Dictionary<string, string> Links { get; set; }
    }
}

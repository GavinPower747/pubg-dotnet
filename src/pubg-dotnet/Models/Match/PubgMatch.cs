using Newtonsoft.Json;
using Pubg.Net.Models.Base;
using System.Collections.Generic;

namespace Pubg.Net
{
    public class PubgMatch : PubgShardedEntity
    {
        [JsonProperty]
        public string CreatedAt { get; set; }

        [JsonProperty]
        public int Duration { get; set; }

        [JsonProperty]
        public IEnumerable<PubgRoster> Rosters { get; set; }

        [JsonProperty]
        public PubgRound Rounds { get; set; }

        [JsonProperty]
        public IEnumerable<PubgAsset> Assets { get; set; }

        [JsonProperty]
        public PubgMatchStats Stats { get; set; }

        [JsonProperty]
        public string GameMode { get; set; }

        [JsonProperty]
        public string PatchVersion { get; set; }

        [JsonProperty]
        public string TitleId { get; set; }

        [JsonProperty]
        public Dictionary<string, object> Links { get; set; }
    }
}

using Newtonsoft.Json;
using System.Collections.Generic;

namespace Pubg.Net
{
    public class PubgMatch : PubgEntity
    {
        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("duration")]
        public int Duration { get; set; }

        [JsonProperty("rosters")]
        public IEnumerable<PubgRoster> Rosters { get; set; }

        [JsonProperty("rounds")]
        public IEnumerable<PubgRound> Rounds { get; set; }

        [JsonProperty("assets")]
        public IEnumerable<PubgAsset> Assets { get; set; }

        [JsonProperty("stats")]
        public IEnumerable<PubgStat> Stats { get; set; }

        [JsonProperty("gameMode")]
        public string GameMode { get; set; }

        [JsonProperty("patchVersion")]
        public string PatchVersion { get; set; }

        [JsonProperty("titleId")]
        public string TitleId { get; set; }
    }
}

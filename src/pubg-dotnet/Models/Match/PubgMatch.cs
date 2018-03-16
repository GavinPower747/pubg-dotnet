using Newtonsoft.Json;
using Pubg.Net.Infrastructure.Attributes;
using Pubg.Net.Infrastructure.JsonConverters;
using Pubg.Net.Models.Base;
using System.Collections.Generic;

namespace Pubg.Net
{
    [JsonConverter(typeof(JsonPathConverter))]
    public class PubgMatch : PubgShardedEntity
    {
        [JsonProperty("attributes.createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("attributes.duration")]
        public int Duration { get; set; }

        [JsonProperty("rosters")]
        [RelatedEnitity("rosters")]
        public IEnumerable<PubgRoster> Rosters { get; set; }

        [JsonProperty("rounds")]
        public IEnumerable<PubgRound> Rounds { get; set; }

        [JsonProperty("assets")]
        [RelatedEnitity("assets")]
        public IEnumerable<PubgAsset> Assets { get; set; }

        [JsonProperty("stats")]
        public IEnumerable<PubgMatchStat> Stats { get; set; }

        [JsonProperty("attributes.gameMode")]
        public string GameMode { get; set; }

        [JsonProperty("attributes.patchVersion")]
        public string PatchVersion { get; set; }

        [JsonProperty("attributes.titleId")]
        public string TitleId { get; set; }

        [JsonProperty("links")]
        public PubgMatchLinks Links { get; set; }
    }
}

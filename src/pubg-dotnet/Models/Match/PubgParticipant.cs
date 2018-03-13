using Newtonsoft.Json;
using System.Collections.Generic;

namespace Pubg.Net
{
    public class PubgParticipant
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("stats")]
        public IEnumerable<PubgStat> Stats { get; set; }

        [JsonProperty("actor")]
        public string Actor { get; set; }

        [JsonProperty("shardId")]
        public string ShardId { get; set; }
    }
}

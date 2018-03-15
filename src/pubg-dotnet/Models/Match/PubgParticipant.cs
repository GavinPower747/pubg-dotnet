using Newtonsoft.Json;
using Pubg.Net.Models.Base;
using System.Collections.Generic;

namespace Pubg.Net
{
    public class PubgParticipant : PubgShardedEntity
    {
        [JsonProperty("stats")]
        public IEnumerable<PubgStat> Stats { get; set; }

        [JsonProperty("actor")]
        public string Actor { get; set; }
    }
}

using Newtonsoft.Json;
using System.Collections.Generic;

namespace Pubg.Net
{
    public class PubgParticipant : PubgEntity
    {
        [JsonProperty("stats")]
        public IEnumerable<PubgStat> Stats { get; set; }

        [JsonProperty("actor")]
        public string Actor { get; set; }
    }
}

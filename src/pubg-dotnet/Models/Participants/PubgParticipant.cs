using Newtonsoft.Json;
using Pubg.Net.Models.Base;

namespace Pubg.Net
{
    public class PubgParticipant : PubgShardedEntity
    {
        [JsonProperty("stats")]
        public PubgParticipantStats Stats { get; set; }

        [JsonProperty("actor")]
        public string Actor { get; set; }

        [JsonProperty("player")]
        public PubgPlayer Player { get; set; }
    }
}

using Newtonsoft.Json;
using Pubg.Net.Models.Base;

namespace Pubg.Net
{
    public class PubgParticipant : PubgShardedEntity
    {
        [JsonProperty]
        public PubgParticipantStats Stats { get; set; }

        [JsonProperty]
        public string Actor { get; set; }

        [JsonProperty]
        public PubgMatchPlayer Player { get; set; }
    }
}

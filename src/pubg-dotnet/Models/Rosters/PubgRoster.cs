using Newtonsoft.Json;
using Pubg.Net.Models.Base;
using System.Collections.Generic;

namespace Pubg.Net
{
    public class PubgRoster : PubgShardedEntity
    {
        [JsonProperty]
        public PubgRosterStats Stats { get; set; }

        [JsonProperty]
        public bool Won { get; set; }

        [JsonProperty]
        public IEnumerable<PubgParticipant> Participants { get; set; }
    }
}

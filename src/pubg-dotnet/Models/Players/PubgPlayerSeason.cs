using Newtonsoft.Json;
using Pubg.Net.Infrastructure.JsonConverters;
using System.Collections.Generic;

namespace Pubg.Net
{
    public class PubgPlayerSeason : PubgStatEntity
    {        
        [JsonProperty("matchesSolo")]
        [JsonConverter(typeof(RelationshipIdConverter))]
        public IEnumerable<string> SoloMatchIds { get; set; }

        [JsonProperty("matchesSoloFPP")]
        [JsonConverter(typeof(RelationshipIdConverter))]
        public IEnumerable<string> SoloFPPMatchIds { get; set; }

        [JsonProperty("matchesDuo")]
        [JsonConverter(typeof(RelationshipIdConverter))]
        public IEnumerable<string> DuoMatchIds { get; set; }

        [JsonProperty("matchesDuoFPP")]
        [JsonConverter(typeof(RelationshipIdConverter))]
        public IEnumerable<string> DuoFPPMatchIds { get; set; }

        [JsonProperty("matchesSquad")]
        [JsonConverter(typeof(RelationshipIdConverter))]
        public IEnumerable<string> SquadMatchIds { get; set; }

        [JsonProperty("matchesSquadFPP")]
        [JsonConverter(typeof(RelationshipIdConverter))]
        public IEnumerable<string> SquadFPPMatchIds { get; set; }
    }
}

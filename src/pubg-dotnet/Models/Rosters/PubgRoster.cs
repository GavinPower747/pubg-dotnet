using Newtonsoft.Json;
using Pubg.Net.Infrastructure.Attributes;
using Pubg.Net.Infrastructure.JsonConverters;
using Pubg.Net.Models.Base;
using System.Collections.Generic;

namespace Pubg.Net
{
    [JsonConverter(typeof(JsonPathConverter))]
    public class PubgRoster : PubgShardedEntity
    {
        [JsonProperty("attributes.stats")]
        public PubgRosterStats Stats { get; set; }

        [JsonProperty("attributes.won")]
        public bool Won { get; set; }

        [JsonProperty("participants")]
        [RelatedEnitity("participants")]
        public IEnumerable<PubgParticipant> Participants { get; set; }
    }
}

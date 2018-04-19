using Newtonsoft.Json;
using Pubg.Net.Infrastructure.JsonConverters;
using Pubg.Net.Models.Base;
using System;
using System.Collections.Generic;

namespace Pubg.Net.Models.Samples
{
    public class PubgMatchSample : PubgShardedEntity
    {
        [JsonProperty]
        public DateTime CreatedAt { get; set; }
        
        [JsonProperty]
        public string TitleId { get; set; }

        [JsonProperty("matches")]
        [JsonConverter(typeof(RelationshipIdConverter))]
        public IEnumerable<string> MatchIds { get; set; }
    }
}

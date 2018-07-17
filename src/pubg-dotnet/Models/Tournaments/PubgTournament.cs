using Newtonsoft.Json;
using Pubg.Net.Infrastructure.JsonConverters;
using Pubg.Net.Models.Base;
using System.Collections.Generic;

namespace Pubg.Net
{
    public class PubgTournament : PubgEntity
    {
        [JsonProperty]
        public string Type { get; set; }

        [JsonProperty("matches")]
        [JsonConverter(typeof(RelationshipIdConverter))]
        public IEnumerable<string> MatchIds { get; set; }
    }
}

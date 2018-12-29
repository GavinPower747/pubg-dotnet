using Newtonsoft.Json;
using Pubg.Net.Infrastructure.JsonConverters;
using Pubg.Net.Models.Base;
using Pubg.Net.Models.Stats;

namespace Pubg.Net
{
    public class PubgStatEntity : PubgEntity
    {
        [JsonProperty]
        public PubgSeasonStats GameModeStats { get; set; }

        [JsonProperty("player")]
        [JsonConverter(typeof(RelationshipIdConverter))]
        public string PlayerId { get; set; }

        [JsonProperty("season")]
        [JsonConverter(typeof(RelationshipIdConverter))]
        public string SeasonId { get; set; }
    }
}

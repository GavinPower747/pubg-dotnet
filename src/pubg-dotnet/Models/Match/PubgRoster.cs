using Newtonsoft.Json;
using Pubg.Net.Models.Base;

namespace Pubg.Net
{
    public class PubgRoster : PubgShardedEntity
    {
        [JsonProperty("team")]
        public PubgTeam Team { get; set; }
    }
}

using Newtonsoft.Json;

namespace Pubg.Net
{
    public class PubgRoster : PubgEntity
    {
        [JsonProperty("team")]
        public PubgTeam Team { get; set; }
    }
}

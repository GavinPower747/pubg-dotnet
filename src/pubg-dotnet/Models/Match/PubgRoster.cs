using Newtonsoft.Json;

namespace Pubg.Net
{
    public class PubgRoster
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("team")]
        public PubgTeam Team { get; set; }
    }
}

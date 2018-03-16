using Newtonsoft.Json;

namespace Pubg.Net
{
    public class PubgRosterStats
    {
        [JsonProperty("rank")]
        public int Rank { get; set; }

        [JsonProperty("teamId")]
        public int TeamId { get; set; }
    }
}

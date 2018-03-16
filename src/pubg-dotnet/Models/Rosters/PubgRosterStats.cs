using Newtonsoft.Json;

namespace Pubg.Net
{
    public class PubgRosterStats
    {
        [JsonProperty]
        public int Rank { get; set; }

        [JsonProperty]
        public int TeamId { get; set; }
    }
}

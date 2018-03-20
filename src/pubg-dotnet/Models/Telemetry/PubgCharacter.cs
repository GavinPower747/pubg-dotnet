using Newtonsoft.Json;

namespace Pubg.Net.Models.Telemetry
{
    public class PubgCharacter
    {
        [JsonProperty]
        public string Name { get; set; }

        [JsonProperty]
        public int TeamId { get; set; }

        [JsonProperty]
        public float Health { get; set; }

        [JsonProperty]
        public Location Location { get; set; }

        [JsonProperty]
        public int Ranking { get; set; }

        [JsonProperty]
        public string AccountId { get; set; }
    }
}

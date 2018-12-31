using Newtonsoft.Json;

namespace Pubg.Net
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

        [JsonProperty]
        public bool IsInRedZone { get; set; }

        [JsonProperty]
        public bool IsInBlueZone { get; set; }

        [JsonProperty]
        public string[] Zone { get; set; }
    }
}

using Newtonsoft.Json;

namespace Pubg.Net.Models.Telemetry
{
    public class PubgBlueZoneConfig
    {
        [JsonProperty]
        public int PhaseNum { get; set; }

        [JsonProperty]
        public int StartDelay { get; set; }

        [JsonProperty]
        public int WarningDuration { get; set; }

        [JsonProperty]
        public int ReleaseDuration { get; set; }

        [JsonProperty]
        public float PoisonGasDamagePerSecond { get; set; }

        [JsonProperty]
        public float RadiusRate { get; set; }

        [JsonProperty]
        public float SpreadRatio { get; set; }

        [JsonProperty]
        public float LandRatio { get; set; }

        [JsonProperty]
        public int CircleAlgorithm { get; set; }
    }
}

using Newtonsoft.Json;

namespace Pubg.Net.Models.Telemetry
{
    public class PubgTelemetryStats
    {
        [JsonProperty]
        public int KillCount { get; set; }

        [JsonProperty]
        public float DistanceOnFoot { get; set; }

        [JsonProperty]
        public float DistanceOnSwim { get; set; }

        [JsonProperty]
        public float DistanceOnVehicle { get; set; }

        [JsonProperty]
        public float DistanceOnParachute { get; set; }

        [JsonProperty]
        public float DistanceOnFreefall { get; set; }
    }
}

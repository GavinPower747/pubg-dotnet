using Newtonsoft.Json;

namespace Pubg.Net.Models.Telemetry
{
    public class PubgVehicle
    {
        [JsonProperty]
        public string VehicleType { get; set; }

        [JsonProperty]
        public string VehicleId { get; set; }

        [JsonProperty]
        public float HealthPercent { get; set; }

        [JsonProperty]
        public float FeulPercent { get; set; }
    }
}

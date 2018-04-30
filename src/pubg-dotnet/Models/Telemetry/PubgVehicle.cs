using Newtonsoft.Json;
using Pubg.Net.Models.Telemetry.Enums;

namespace Pubg.Net
{
    public class PubgVehicle
    {
        [JsonProperty]
        public PubgVehicleType VehicleType { get; set; }

        [JsonProperty]
        public string VehicleId { get; set; }

        [JsonProperty]
        public float HealthPercent { get; set; }

        [JsonProperty]
        public float FeulPercent { get; set; }
    }
}

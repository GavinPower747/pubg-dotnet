using Newtonsoft.Json;

namespace Pubg.Net.Models.Telemetry.Events
{
    public class LogVehicleRide : PubgTelemetryEvent
    {
        [JsonProperty]
        public PubgCharacter Character { get; set; }

        [JsonProperty]
        public PubgVehicle Vehicle { get; set; }
    }
}

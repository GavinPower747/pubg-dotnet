using Newtonsoft.Json;

namespace Pubg.Net
{
    public class LogVehicleRide : PubgTelemetryEvent
    {
        [JsonProperty]
        public PubgCharacter Character { get; set; }

        [JsonProperty]
        public PubgVehicle Vehicle { get; set; }
    }
}

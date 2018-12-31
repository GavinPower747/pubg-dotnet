using Newtonsoft.Json;

namespace Pubg.Net
{
    public class LogVehicleLeave : PubgTelemetryEvent
    {
        [JsonProperty]
        public PubgCharacter Character { get; set; }

        [JsonProperty]
        public PubgVehicle Vehicle { get; set; }

        [JsonProperty]
        public float RideDistance { get; set; }

        [JsonProperty]
        public int SeatIndex { get; set; }

        [JsonProperty]
        public float MaxSpeed { get; set; }
    }
}

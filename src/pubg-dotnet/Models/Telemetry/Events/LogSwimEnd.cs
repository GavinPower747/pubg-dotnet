using Newtonsoft.Json;

namespace Pubg.Net.Models.Telemetry.Events
{
    public class LogSwimEnd : PubgTelemetryEvent
    {
        [JsonProperty]
        public PubgCharacter Character { get; set; }

        [JsonProperty]
        public float SwimDistance { get; set; }
    }
}

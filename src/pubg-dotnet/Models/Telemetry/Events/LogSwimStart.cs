using Newtonsoft.Json;

namespace Pubg.Net.Models.Telemetry.Events
{
    public class LogSwimStart : PubgTelemetryEvent
    {
        [JsonProperty]
        public PubgCharacter Character { get; set; }
    }
}

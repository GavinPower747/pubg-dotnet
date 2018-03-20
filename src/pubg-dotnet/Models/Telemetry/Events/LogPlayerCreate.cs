using Newtonsoft.Json;

namespace Pubg.Net.Models.Telemetry.Events
{
    public class LogPlayerCreate : PubgTelemetryEvent
    {
        [JsonProperty]
        public PubgCharacter Character { get; set; }
    }
}

using Newtonsoft.Json;

namespace Pubg.Net.Models.Telemetry.Events
{
    public class LogParachuteLanding : PubgTelemetryEvent
    {
        [JsonProperty]
        public PubgCharacter Character { get; set; }

        [JsonProperty]
        public float Distance { get; set; }
    }
}

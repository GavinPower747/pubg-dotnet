using Newtonsoft.Json;

namespace Pubg.Net.Models.Telemetry.Events
{
    public class LogItemUse : PubgTelemetryEvent
    {
        [JsonProperty]
        public PubgCharacter Character { get; set; }

        [JsonProperty]
        public PubgItem Item { get; set; }
    }
}

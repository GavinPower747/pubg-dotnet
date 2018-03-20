using Newtonsoft.Json;

namespace Pubg.Net.Models.Telemetry.Events
{
    public class LogItemDetach : PubgTelemetryEvent
    {
        [JsonProperty]
        public PubgCharacter Character { get; set; }

        [JsonProperty]
        public PubgItem ParentItem { get; set; }

        [JsonProperty]
        public PubgItem ChildItem { get; set; }
    }
}

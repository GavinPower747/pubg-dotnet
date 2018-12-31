using Newtonsoft.Json;

namespace Pubg.Net.Models.Telemetry.Events
{
    public class LogObjectDestroy : PubgTelemetryEvent
    {
        [JsonProperty]
        public PubgCharacter Character { get; set; }

        [JsonProperty]
        public string ObjectType { get; set; }

        [JsonProperty]
        public Location ObjectLocation { get; set; }
    }
}

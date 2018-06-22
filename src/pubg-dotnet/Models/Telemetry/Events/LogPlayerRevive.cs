using Newtonsoft.Json;

namespace Pubg.Net.Models.Telemetry.Events
{
    public class LogPlayerRevive : PubgTelemetryEvent
    {
        [JsonProperty]
        public PubgCharacter Reviver { get; set; }

        [JsonProperty]
        public PubgCharacter Victim { get; set; }
    }
}

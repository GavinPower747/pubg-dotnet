using Newtonsoft.Json;

namespace Pubg.Net.Models.Telemetry.Events
{
    public class LogHeal: PubgTelemetryEvent
    {
        [JsonProperty]
        public PubgCharacter Character { get; set; }

        [JsonProperty]
        public PubgItem Item { get; set; }

        [JsonProperty]
        public float HealAmount { get; set; }
    }
}

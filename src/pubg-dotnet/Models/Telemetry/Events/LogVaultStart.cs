using Newtonsoft.Json;

namespace Pubg.Net.Models.Telemetry.Events
{
    public class LogVaultStart : PubgTelemetryEvent
    {
        [JsonProperty]
        public PubgCharacter Character { get; set; }
    }
}

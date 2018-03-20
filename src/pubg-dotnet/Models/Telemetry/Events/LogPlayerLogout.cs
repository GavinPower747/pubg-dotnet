using Newtonsoft.Json;

namespace Pubg.Net.Models.Telemetry.Events
{
    public class LogPlayerLogout : PubgTelemetryEvent
    {
        [JsonProperty]
        public string AccountId { get; set; }s
    }
}

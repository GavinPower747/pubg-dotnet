using Newtonsoft.Json;

namespace Pubg.Net.Models.Telemetry.Events
{
    public class LogMatchDefinition : PubgTelemetryEvent
    {
        [JsonProperty]
        public string MatchId { get; set; }
    }
}

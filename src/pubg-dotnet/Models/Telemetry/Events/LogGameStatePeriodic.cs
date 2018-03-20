using Newtonsoft.Json;

namespace Pubg.Net.Models.Telemetry.Events
{
    public class LogGameStatePeriodic : PubgTelemetryEvent
    {
        [JsonProperty]
        public PubgGameState GameState { get; set; }
    }
}

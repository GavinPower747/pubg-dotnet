using Newtonsoft.Json;

namespace Pubg.Net
{
    public class LogGameStatePeriodic : PubgTelemetryEvent
    {
        [JsonProperty]
        public PubgGameState GameState { get; set; }
    }
}

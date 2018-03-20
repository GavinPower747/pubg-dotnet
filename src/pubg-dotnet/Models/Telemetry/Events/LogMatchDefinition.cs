using Newtonsoft.Json;

namespace Pubg.Net
{
    public class LogMatchDefinition : PubgTelemetryEvent
    {
        [JsonProperty]
        public string MatchId { get; set; }
    }
}

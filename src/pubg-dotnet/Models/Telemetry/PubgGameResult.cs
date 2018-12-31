using Newtonsoft.Json;

namespace Pubg.Net.Models.Telemetry
{
    public class PubgGameResult
    {
        [JsonProperty]
        public int Rank { get; set; }

        [JsonProperty]
        public string GameResult { get; set; }

        [JsonProperty]
        public int TeamId { get; set; }

        [JsonProperty]
        public PubgTelemetryStats Stats { get; set; }

        [JsonProperty]
        public string AccountId { get; set; }
    }
}

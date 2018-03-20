using Newtonsoft.Json;

namespace Pubg.Net.Models.Telemetry.Events
{
    public class LogPlayerLogin : PubgTelemetryEvent
    {
        [JsonProperty]
        public bool Result { get; set; }

        [JsonProperty]
        public string ErrorMessge { get; set; }

        [JsonProperty]
        public string AccountId { get; set; }
    }
}

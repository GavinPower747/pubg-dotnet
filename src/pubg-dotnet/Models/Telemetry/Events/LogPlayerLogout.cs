using Newtonsoft.Json;

namespace Pubg.Net
{
    public class LogPlayerLogout : PubgTelemetryEvent
    {
        [JsonProperty]
        public string AccountId { get; set; }
    }
}

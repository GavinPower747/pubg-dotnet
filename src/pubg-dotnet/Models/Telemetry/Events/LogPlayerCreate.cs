using Newtonsoft.Json;

namespace Pubg.Net
{
    public class LogPlayerCreate : PubgTelemetryEvent
    {
        [JsonProperty]
        public PubgCharacter Character { get; set; }
    }
}

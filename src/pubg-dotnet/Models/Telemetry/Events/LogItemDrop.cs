using Newtonsoft.Json;

namespace Pubg.Net
{
    public class LogItemDrop : PubgTelemetryEvent
    {
        [JsonProperty]
        public PubgCharacter Character { get; set; }

        [JsonProperty]
        public PubgItem Item { get; set; }
    }
}

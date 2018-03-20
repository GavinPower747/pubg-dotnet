using Newtonsoft.Json;

namespace Pubg.Net
{
    public class LogItemDetach : PubgTelemetryEvent
    {
        [JsonProperty]
        public PubgCharacter Character { get; set; }

        [JsonProperty]
        public PubgItem ParentItem { get; set; }

        [JsonProperty]
        public PubgItem ChildItem { get; set; }
    }
}

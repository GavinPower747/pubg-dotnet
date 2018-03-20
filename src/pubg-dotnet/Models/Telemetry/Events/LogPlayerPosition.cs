using Newtonsoft.Json;

namespace Pubg.Net
{
    public class LogPlayerPosition : PubgTelemetryEvent
    {
        [JsonProperty]
        public PubgCharacter Character { get; set; }

        [JsonProperty]
        public float ElapsedTime { get; set; }

        [JsonProperty]
        public int NumAlivePlayers { get; set; }
    }
}

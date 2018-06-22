using Newtonsoft.Json;
using Pubg.Net.Models.Telemetry;
using System.Collections.Generic;

namespace Pubg.Net
{
    public class LogMatchStart : PubgTelemetryEvent
    {
        [JsonProperty]
        public IEnumerable<PubgCharacter> Characters { get; set; }

        [JsonProperty]
        public bool IsCustomGame { get; set; }

        [JsonProperty]
        public bool IsEventMode { get; set; }

        [JsonProperty]
        public string CameraViewBehaviour { get; set; }

        [JsonProperty]
        public int TeamSize { get; set; }

        [JsonProperty]
        public PubgBlueZoneConfig[] BlueZoneCustomOptions { get; set; }

        [JsonProperty]
        public PubgMap MapName { get; set; }

        [JsonProperty]
        public string WeatherId { get; set; }
    }
}

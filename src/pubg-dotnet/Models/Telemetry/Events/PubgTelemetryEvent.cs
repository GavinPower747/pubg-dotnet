using Newtonsoft.Json;
using Pubg.Net.Infrastructure.JsonConverters;
using Pubg.Net.Models.Telemetry;
using System;

namespace Pubg.Net
{
    [JsonConverter(typeof(PubgTelemetryConverter))]
    public class PubgTelemetryEvent
    {
        [JsonProperty("_V")]
        public string Version { get; set; }

        [JsonProperty("_D")]
        public DateTime Timestamp { get; set; }

        [JsonProperty("_T")]
        public string Type { get; set; }

        [JsonProperty]
        public PubgCommonTelemetry Common { get; set; }
    }
}

using Newtonsoft.Json;

namespace Pubg.Net.Models.Telemetry.Events
{
    public class LogCarePackageLand : PubgTelemetryEvent
    {
        [JsonProperty]
        public PubgItemPackage ItemPackage { get; set; }
    }
}

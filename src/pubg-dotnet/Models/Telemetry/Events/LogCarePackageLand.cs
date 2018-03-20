using Newtonsoft.Json;

namespace Pubg.Net
{
    public class LogCarePackageLand : PubgTelemetryEvent
    {
        [JsonProperty]
        public PubgItemPackage ItemPackage { get; set; }
    }
}

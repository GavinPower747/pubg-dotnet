using Newtonsoft.Json;

namespace Pubg.Net.Models.Telemetry.Events
{
    public class LogCarePackageSpawn : PubgTelemetryEvent
    {
        [JsonProperty]
        public PubgItemPackage ItemPackage { get; set; }
    }
}

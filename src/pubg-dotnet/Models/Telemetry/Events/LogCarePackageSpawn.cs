using Newtonsoft.Json;

namespace Pubg.Net
{
    public class LogCarePackageSpawn : PubgTelemetryEvent
    {
        [JsonProperty]
        public PubgItemPackage ItemPackage { get; set; }
    }
}

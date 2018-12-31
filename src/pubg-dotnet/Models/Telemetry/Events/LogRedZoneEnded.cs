using Newtonsoft.Json;

namespace Pubg.Net.Models.Telemetry.Events
{
    public class LogRedZoneEnded : PubgTelemetryEvent 
    {
        [JsonProperty]
        public PubgCharacter[] Drivers { get; set; }
    }
}

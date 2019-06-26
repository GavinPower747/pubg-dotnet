using Newtonsoft.Json;

namespace Pubg.Net.Models.Telemetry.Events
{
    public class LogWeaponFireCount : PubgTelemetryEvent
    {
        [JsonProperty]
        public PubgCharacter Character { get; set; }

        [JsonProperty]
        public string WeaponId { get; set; }

        [JsonProperty]
        public int FireCount { get; set; }
    }
}

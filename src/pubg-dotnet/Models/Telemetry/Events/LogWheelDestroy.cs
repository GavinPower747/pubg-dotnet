using Newtonsoft.Json;

namespace Pubg.Net.Models.Telemetry.Events
{
    public class LogWheelDestroy : PubgTelemetryEvent
    {
        [JsonProperty]
        public int AttackId { get; set; }

        [JsonProperty]
        public PubgCharacter Attacker { get; set; }

        [JsonProperty]
        public PubgVehicle Vehicle { get; set; }

        [JsonProperty]
        public string DamageTypeCategory { get; set; }

        [JsonProperty]
        public string DamageCauserName { get; set; }
    }
}

using Newtonsoft.Json;

namespace Pubg.Net
{
    public class LogVehicleDestroy : PubgTelemetryEvent
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

        [JsonProperty]
        public float Distance { get; set; }
    }
}

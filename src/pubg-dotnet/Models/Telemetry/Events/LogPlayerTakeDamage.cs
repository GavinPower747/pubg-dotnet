using Newtonsoft.Json;

namespace Pubg.Net
{
    public class LogPlayerTakeDamage : PubgTelemetryEvent
    {
        [JsonProperty]
        public int AttackId { get; set; }

        [JsonProperty]
        public PubgCharacter Attacker { get; set; }

        [JsonProperty]
        public PubgCharacter Victim { get; set; }

        [JsonProperty]
        public string DamageTypeCategory { get; set; }

        [JsonProperty]
        public string DamageReason { get; set; }

        [JsonProperty]
        public float Damage { get; set; }

        [JsonProperty]
        public string DamageCauserName { get; set; }
    }
}

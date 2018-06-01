using Newtonsoft.Json;
using Pubg.Net.Models.Telemetry.Enums;

namespace Pubg.Net.Models.Telemetry.Events
{
    public class LogArmorDestroy : PubgTelemetryEvent
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
        public PubgDamageReason DamageReason { get; set; }

        [JsonProperty]
        public string DamageCauserName { get; set; }

        [JsonProperty]
        public PubgItem Item { get; set; }

        [JsonProperty]
        public float Distance { get; set; }
    }
}

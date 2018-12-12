using Newtonsoft.Json;
using Pubg.Net.Models.Telemetry.Enums;

namespace Pubg.Net
{
    public class LogPlayerAttack : PubgTelemetryEvent
    {
        [JsonProperty]
        public int AttackId { get; set; }

        [JsonProperty]
        public PubgCharacter Attacker { get; set; }

        [JsonProperty]
        public PubgAttackType AttackType { get; set; }

        [JsonProperty]
        public int FireWeaponStackCount { get; set; }

        [JsonProperty]
        public PubgItem Weapon { get; set; }

        [JsonProperty]
        public PubgVehicle Vehicle { get; set; }
    }
}

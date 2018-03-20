using Newtonsoft.Json;

namespace Pubg.Net
{
    public class LogPlayerAttack : PubgTelemetryEvent
    {
        [JsonProperty]
        public int AttackId { get; set; }

        [JsonProperty]
        public PubgCharacter Attacker { get; set; }

        [JsonProperty]
        public string AttackType { get; set; }

        [JsonProperty]
        public PubgItem Weapon { get; set; }

        [JsonProperty]
        public PubgVehicle Vehicle { get; set; }
    }
}

using Newtonsoft.Json;
using Pubg.Net.Models.Telemetry;
using Pubg.Net.Models.Telemetry.Enums;

namespace Pubg.Net
{
    public class LogPlayerKill : PubgTelemetryEvent
    {
        [JsonProperty]
        public int AttackId { get; set; }

        [JsonProperty]
        public PubgCharacter Killer { get; set; }

        [JsonProperty]
        public PubgCharacter Victim { get; set; }

        [JsonProperty]
        public string DamageTypeCategory { get; set; }

        [JsonProperty]
        public string DamageCauserName { get; set; }

        [JsonProperty]
        public float Distance { get; set; }

        [JsonProperty]
        public PubgDamageReason DamageReason { get; set; }

        [JsonProperty]
        public PubgCharacter Assistant { get; set; }

        [JsonProperty]
        public string DamageCauserAdditionalInfo { get; set; }

        [JsonProperty]
        public int DBNOId { get; set; }
        
        [JsonProperty]
        public PubgGameResult VictimGameResult { get; set; }
    }
}

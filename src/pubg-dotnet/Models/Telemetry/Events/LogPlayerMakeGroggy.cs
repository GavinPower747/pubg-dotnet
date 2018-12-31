using Newtonsoft.Json;

namespace Pubg.Net.Models.Telemetry.Events
{
    public class LogPlayerMakeGroggy : PubgTelemetryEvent
    {
        [JsonProperty]
        public int AttackerId { get; set; }

        [JsonProperty]
        public PubgCharacter Attacker { get; set; }

        [JsonProperty]
        public PubgCharacter Victim { get; set; }

        [JsonProperty]
        public string DamageTypeCategory { get; set; }

        [JsonProperty]
        public string DamageCauserName { get; set; }

        [JsonProperty]
        public float Distance { get; set; }

        [JsonProperty]
        public bool IsAttackerInVehicle { get; set; }

        [JsonProperty]
        public int DBNOId { get; set; }

        [JsonProperty]
        public string[] DamageCauserAdditionalInfo { get; set; }

        [JsonProperty]
        public string DamageReason { get; set; }
    }
}

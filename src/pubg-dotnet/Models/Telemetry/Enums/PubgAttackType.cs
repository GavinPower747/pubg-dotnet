using Newtonsoft.Json;
using Pubg.Net.Infrastructure.JsonConverters;
using System.Runtime.Serialization;

namespace Pubg.Net.Models.Telemetry.Enums
{
    [JsonConverter(typeof(DefaultValueStringEnumConverter))]
    public enum PubgAttackType
    {
        [EnumMember(Value = "RedZone")]
        RedZone,
        [EnumMember(Value = "Weapon")]
        Weapon
    }
}

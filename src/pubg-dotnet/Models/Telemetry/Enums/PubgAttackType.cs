using System.Runtime.Serialization;

namespace Pubg.Net.Models.Telemetry.Enums
{
    public enum PubgAttackType
    {
        [EnumMember(Value = "RedZone")]
        RedZone,
        [EnumMember(Value = "Weapon")]
        Weapon
    }
}

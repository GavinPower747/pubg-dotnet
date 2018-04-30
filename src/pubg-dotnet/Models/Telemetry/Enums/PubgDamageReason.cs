using System.Runtime.Serialization;

namespace Pubg.Net.Models.Telemetry.Enums
{
    public enum PubgDamageReason
    {
        [EnumMember(Value ="None")]
        None,
        [EnumMember(Value ="NonSpecific")]
        NonSpecific,
        [EnumMember(Value = "ArmShot")]
        ArmShot,
        [EnumMember(Value ="HeadShot")]
        HeadShot,
        [EnumMember(Value ="LegShot")]
        LegShot,
        [EnumMember(Value ="PelvisShot")]
        PelvisShot,
        [EnumMember(Value ="TorsoShot")]
        TorsoShot
    }
}

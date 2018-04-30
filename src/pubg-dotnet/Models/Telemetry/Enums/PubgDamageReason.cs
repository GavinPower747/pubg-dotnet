using Newtonsoft.Json;
using Pubg.Net.Infrastructure.Attributes;
using Pubg.Net.Infrastructure.JsonConverters;
using System.Runtime.Serialization;

namespace Pubg.Net.Models.Telemetry.Enums
{
    [JsonConverter(typeof(DefaultValueStringEnumConverter))]
    public enum PubgDamageReason
    {
        [EnumMember(Value ="None")]
        [DefaultEnumMember]
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

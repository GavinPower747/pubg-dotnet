using Newtonsoft.Json;
using Pubg.Net.Infrastructure.Attributes;
using Pubg.Net.Infrastructure.JsonConverters;
using System.Runtime.Serialization;

namespace Pubg.Net.Models.Telemetry.Enums
{
    [JsonConverter(typeof(DefaultValueStringEnumConverter))]
    public enum PubgItemCategory
    {
        [DefaultEnumMember]
        NotSpecified,
        [EnumMember(Value ="Ammunition")]
        Ammunition,
        [EnumMember(Value ="Attachment")]
        Attachment,
        [EnumMember(Value ="Equipment")]
        Equipment,
        [EnumMember(Value ="Use")]
        Use,
        [EnumMember(Value ="Weapon")]
        Weapon
    }
}

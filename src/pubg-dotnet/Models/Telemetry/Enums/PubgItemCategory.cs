using System.Runtime.Serialization;

namespace Pubg.Net.Models.Telemetry.Enums
{
    public enum PubgItemCategory
    {
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

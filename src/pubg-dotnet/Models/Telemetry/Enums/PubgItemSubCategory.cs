using Newtonsoft.Json;
using Pubg.Net.Infrastructure.Attributes;
using Pubg.Net.Infrastructure.JsonConverters;
using System.Runtime.Serialization;

namespace Pubg.Net.Models.Telemetry.Enums
{
    [JsonConverter(typeof(DefaultValueStringEnumConverter))]
    public enum PubgItemSubCategory
    {
        [EnumMember( Value ="None")]
        [DefaultEnumMember]
        None,
        [EnumMember( Value ="Backpack")]
        Backpack,
        [EnumMember( Value ="Boost")]
        Boost,
        [EnumMember( Value ="Fuel")]
        Fuel,
        [EnumMember( Value ="Handgun")]
        Handgun,
        [EnumMember( Value ="Headgear")]
        Headgear,
        [EnumMember( Value ="Heal")]
        Heal,
        [EnumMember( Value ="Jacket")]
        Jacket,
        [EnumMember( Value ="Main")]
        Main,
        [EnumMember( Value ="Melee")]
        Melee,
        [EnumMember( Value ="Throwable")]
        Throwable,
        [EnumMember( Value ="Vest")]
        Vest
    }
}

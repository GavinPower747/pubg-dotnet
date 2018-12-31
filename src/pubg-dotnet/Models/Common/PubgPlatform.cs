using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace Pubg.Net
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PubgPlatform
    {
        [EnumMember(Value = "steam")]
        Steam,
        [EnumMember(Value = "xbox")]
        Xbox,
        [EnumMember(Value = "psn")]
        PlayStation,
        [EnumMember(Value = "kakao")]
        Kakao,
        [EnumMember(Value = "tournament")]
        Tournament
    }
}

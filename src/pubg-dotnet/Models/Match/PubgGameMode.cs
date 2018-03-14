using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace Pubg.Net
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PubgGameMode
    {
        [EnumMember(Value = "squad")]
        Squad,
        [EnumMember(Value = "solo")]
        Solo,
        [EnumMember(Value = "duo")]
        Duo
    }
}

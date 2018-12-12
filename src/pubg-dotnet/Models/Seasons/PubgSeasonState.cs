using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace Pubg.Net.Models.Seasons
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PubgSeasonState
    {
        [EnumMember(Value = "closed")]
        Closed,
        [EnumMember(Value = "prepare")]
        Prepare,
        [EnumMember(Value = "progress")]
        Progress
    }
}

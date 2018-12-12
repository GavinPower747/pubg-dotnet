using Newtonsoft.Json;
using Pubg.Net.Infrastructure.Attributes;
using Pubg.Net.Infrastructure.JsonConverters;
using System.Runtime.Serialization;

namespace Pubg.Net.Models.Seasons
{
    [JsonConverter(typeof(DefaultValueStringEnumConverter))]
    public enum PubgSeasonState
    {
        [DefaultEnumMember]
        Unknown,
        [EnumMember(Value = "closed")]
        Closed,
        [EnumMember(Value = "prepare")]
        Prepare,
        [EnumMember(Value = "progress")]
        Progress
    }
}

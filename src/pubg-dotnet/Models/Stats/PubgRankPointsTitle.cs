using Newtonsoft.Json;
using Pubg.Net.Infrastructure.Attributes;
using Pubg.Net.Infrastructure.JsonConverters;
using System.Runtime.Serialization;

namespace Pubg.Net.Models.Stats
{
    [JsonConverter(typeof(DefaultValueStringEnumConverter))]
    public enum PubgRankPointsTitle
    {
        [DefaultEnumMember]
        Unknown,
        [EnumMember(Value = "BEGINNER")]
        Beginner,
        [EnumMember(Value = "NOVICE")]
        Novice,
        [EnumMember(Value = "EXPERIENCED")]
        Experienced,
        [EnumMember(Value = "SKILLED")]
        Skilled,
        [EnumMember(Value = "SPECIALIST")]
        Specialist,
        [EnumMember(Value = "EXPERT")]
        Expert,
        [EnumMember(Value = "SURVIVOR")]
        Survivor,
        [EnumMember(Value = "LONE SURVIVOR")]
        LoneSurvivor
    }
}

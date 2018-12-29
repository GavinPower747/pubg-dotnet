using Newtonsoft.Json;
using Pubg.Net.Infrastructure.Attributes;
using Pubg.Net.Infrastructure.JsonConverters;
using System.Runtime.Serialization;

namespace Pubg.Net
{
    [JsonConverter(typeof(DefaultValueStringEnumConverter))]
    public enum PubgGameMode
    {
        [DefaultEnumMember]
        Unknown,
        [EnumMember(Value = "squad")]
        Squad,
        [EnumMember(Value = "squad-fpp")]
        SquadFPP,
        [EnumMember(Value = "solo")]
        Solo,
        [EnumMember(Value = "solo-fpp")]
        SoloFPP,
        [EnumMember(Value = "duo")]
        Duo,
        [EnumMember(Value = "duo-fpp")]
        DuoFPP,
        [EnumMember(Value = "normal-duo")]
        NormalDuo,
        [EnumMember(Value = "normal-duo-fpp")]
        NormalDuoFPP,
        [EnumMember(Value = "normal-solo")]
        NormalSolo,
        [EnumMember(Value = "normal-solo-fpp")]
        NormalSoloFPP,
        [EnumMember(Value = "normal-squad")]
        NormalSquad,
        [EnumMember(Value = "normal-squad-fpp")]
        NormalSquadFPP
    }
}

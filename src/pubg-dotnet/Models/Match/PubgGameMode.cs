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
        NormalSquadFPP,

        [EnumMember(Value = "conquest-duo")]
        ConquestDuo,
        [EnumMember(Value = "conquest-duo-fpp")]
        ConquestDuoFPP,
        [EnumMember(Value = "conquest-solo")]
        ConquestSolo,
        [EnumMember(Value = "conquest-solo-fpp")]
        ConquestSoloFPP,
        [EnumMember(Value = "conquest-squad")]
        ConquestSquad,
        [EnumMember(Value = "conquest-squad-fpp")]
        ConquestSquadFPP,

        [EnumMember(Value = "esports-duo")]
        EsportsDuo,
        [EnumMember(Value = "esports-duo-fpp")]
        EsportsDuoFPP,
        [EnumMember(Value = "esports-solo")]
        EsportsSolo,
        [EnumMember(Value = "esports-solo-fpp")]
        EsportsSoloFPP,
        [EnumMember(Value = "esports-squad")]
        EsportsSquad,
        [EnumMember(Value = "esports-squad-fpp")]
        EsportsSquadFPP,

        [EnumMember(Value = "war-duo")]
        WarDuo,
        [EnumMember(Value = "war-duo-fpp")]
        WarDuoFPP,
        [EnumMember(Value = "war-solo")]
        WarSolo,
        [EnumMember(Value = "war-solo-fpp")]
        WarSoloFPP,
        [EnumMember(Value = "war-squad")]
        WarSquad,
        [EnumMember(Value = "war-squad-fpp")]
        WarSquadFPP,

        [EnumMember(Value = "zombie-duo")]
        ZombieDuo,
        [EnumMember(Value = "zombie-duo-fpp")]
        ZombieDuoFPP,
        [EnumMember(Value = "zombie-solo")]
        ZombieSolo,
        [EnumMember(Value = "zombie-solo-fpp")]
        ZombieSoloFPP,
        [EnumMember(Value = "zombie-squad")]
        ZombieSquad,
        [EnumMember(Value = "zombie-squad-fpp")]
        ZombieSquadFPP
    }
}

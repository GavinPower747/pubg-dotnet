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
        [EnumMember (Value = "duo")]
        Duo,
        [EnumMember (Value = "duo-fpp")]
        DuoFpp,
        [EnumMember (Value = "solo")]
        Solo,
        [EnumMember (Value = "solo-fpp")]
        SoloFpp,
        [EnumMember (Value = "squad")]
        Squad,
        [EnumMember (Value = "squad-fpp")]
        SquadFpp,
        [EnumMember (Value = "conquest-duo")]
        ConquestDuo,
        [EnumMember (Value = "conquest-duo-fpp")]
        ConquestDuoFpp,
        [EnumMember (Value = "conquest-solo")]
        ConquestSolo,
        [EnumMember (Value = "conquest-solo-fpp")]
        ConquestSoloFpp,
        [EnumMember (Value = "conquest-squad")]
        ConquestSquad,
        [EnumMember (Value = "conquest-squad-fpp")]
        ConquestSquadFpp,
        [EnumMember (Value = "esports-duo")]
        EsportsDuo,
        [EnumMember (Value = "esports-duo-fpp")]
        EsportsDuoFpp,
        [EnumMember (Value = "esports-solo")]
        EsportsSolo,
        [EnumMember (Value = "esports-solo-fpp")]
        EsportsSoloFpp,
        [EnumMember (Value = "esports-squad")]
        EsportsSquad,
        [EnumMember (Value = "esports-squad-fpp")]
        EsportsSquadFpp,
        [EnumMember (Value = "normal-duo")]
        NormalDuo,
        [EnumMember (Value = "normal-duo-fpp")]
        NormalDuoFpp,
        [EnumMember (Value = "normal-solo")]
        NormalSolo,
        [EnumMember (Value = "normal-solo-fpp")]
        NormalSoloFpp,
        [EnumMember (Value = "normal-squad")]
        NormalSquad,
        [EnumMember (Value = "normal-squad-fpp")]
        NormalSquadFpp,
        [EnumMember (Value = "war-duo")]
        WarDuo,
        [EnumMember (Value = "war-duo-fpp")]
        WarDuoFpp,
        [EnumMember (Value = "war-solo")]
        WarSolo,
        [EnumMember (Value = "war-solo-fpp")]
        WarSoloFpp,
        [EnumMember (Value = "war-squad")]
        WarSquad,
        [EnumMember (Value = "war-squad-fpp")]
        WarSquadFpp,
        [EnumMember (Value = "zombie-duo")]
        ZombieDuo,
        [EnumMember (Value = "zombie-duo-fpp")]
        ZombieDuoFpp,
        [EnumMember (Value = "zombie-solo")]
        ZombieSolo,
        [EnumMember (Value = "zombie-solo-fpp")]
        ZombieSoloFpp,
        [EnumMember (Value = "zombie-squad")]
        ZombieSquad,
        [EnumMember (Value = "zombie-squad-fpp")]
        ZombieSquadFpp
    }
}

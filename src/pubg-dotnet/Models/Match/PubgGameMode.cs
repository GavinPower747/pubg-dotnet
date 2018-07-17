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
        [EnumMember(Value = "warmodetpp")]
        WarModeTPP,
        [EnumMember(Value = "warmodefpp")]
        WarModeFPP
    }
}

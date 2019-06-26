using Newtonsoft.Json;
using Pubg.Net.Infrastructure.Attributes;
using Pubg.Net.Infrastructure.JsonConverters;
using System.Runtime.Serialization;

namespace Pubg.Net
{
    [JsonConverter(typeof(DefaultValueStringEnumConverter))]
    public enum PubgMap
    {
        //In some of the Telemetry they return an empty string
        [DefaultEnumMember]
        Unspecified,
        [EnumMember( Value = "Erangel_Main" )]
        Erangel,
        [EnumMember( Value = "Desert_Main" )]
        Miramar,
        [EnumMember(Value = "Savage_Main")]
        Sanhok,
        [EnumMember(Value = "Range_Main")]
        TrainingRange,
        [EnumMember(Value = "DihorOtok_Main")]
        Vikendi
    }
}

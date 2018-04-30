using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace Pubg.Net
{
    [JsonConverter( typeof( StringEnumConverter ) )]
    public enum PubgMap
    {
        [EnumMember( Value = "Erangel_Main" )]
        Erangel,
        [EnumMember( Value = "Desert_Main" )]
        Miramar
    }
}

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace Pubg.Net
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PubgRegion
    {
         //Xbox Regions
         [EnumMember(Value = "xbox-as")]
         XboxAsia,

         [EnumMember(Value = "xbox-eu")]
         XboxEurope,

         [EnumMember(Value = "xbox-na")]
         XboxNorthAmerica,

         [EnumMember(Value = "xbox-oc")]
         XboxOceania,

         //PC Regions
         [EnumMember(Value = "pc-as")]
         PCAsia,

         [EnumMember(Value = "pc-eu")]
         PCEurope,

         [EnumMember(Value = "pc-ru")]
         PCRussia,

         [EnumMember(Value = "pc-kakao")]
         PCKakao, //What?

         [EnumMember(Value = "pc-krjp")]
         PCKorea,

         [EnumMember(Value = "pc-jp")]
         PCJapan,

         [EnumMember(Value = "pc-na")]
         PCNorthAmerica,

         [EnumMember(Value = "pc-oc")]
         PCOceania,

         [EnumMember(Value = "pc-sa")]
         PCSouthAndCentralAmerica,

         [EnumMember(Value = "pc-sea")]
         PCSouthEastAsia
    }
}

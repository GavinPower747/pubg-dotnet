using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text;

namespace Pubg.Net.Infrastructure
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum Region
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

         [EnumMember(Value = "pc-kakao")]
         PCKakao, //What?

         [EnumMember(Value = "pc-krjp")]
         PCKoreaJapan,

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

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

         [Region("xbox-oc")]
         XboxOceania
    }
}

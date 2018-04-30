using System;
using System.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Pubg.Net.Infrastructure.Attributes;

namespace Pubg.Net.Infrastructure.JsonConverters
{
    public class DefaultValueStringEnumConverter : StringEnumConverter
    {
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if(string.IsNullOrEmpty(reader.Value.ToString()))
            {
                var defaultMember = objectType.GetMembers().FirstOrDefault(f => f.GetCustomAttributes(typeof(DefaultEnumMemberAttribute), false).Count() > 0);

                return Enum.Parse(objectType, defaultMember.Name);
            }

            return base.ReadJson(reader, objectType, existingValue, serializer);
        }
    }
}

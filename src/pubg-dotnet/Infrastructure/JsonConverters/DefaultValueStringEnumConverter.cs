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
            Enum convertedObject;
            
            try
            {
				var obj = base.ReadJson(reader, objectType, existingValue, serializer);
                convertedObject = (Enum) Enum.Parse(objectType, obj.ToString());
            }
            catch
            {
                var defaultMember = objectType.GetMembers().FirstOrDefault(f => f.GetCustomAttributes(typeof(DefaultEnumMemberAttribute), false).Count() > 0);
                convertedObject = (Enum) Enum.Parse(objectType, defaultMember.Name);
            }

            return convertedObject;
        }
    }
}

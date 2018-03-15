using Newtonsoft.Json;
using System;
using System.Reflection;

namespace Pubg.Net.Infrastructure.Parsers
{
    public class EnumParser : IParser
    {
        public bool CanParse(PropertyInfo prop, object propValue)
        {
            var type = prop.PropertyType;

            if (type.GetTypeInfo().IsGenericType && type.GetGenericTypeDefinition() == typeof(Nullable<>))
            {
                type = Nullable.GetUnderlyingType(type);
            }

            return type.GetTypeInfo().IsEnum;
        }

        public string Parse(PropertyInfo prop, object propValue) => JsonConvert.SerializeObject(propValue).Trim('"');
    }
}

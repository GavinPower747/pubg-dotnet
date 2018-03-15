using System;
using System.Reflection;

namespace Pubg.Net.Infrastructure.Parsers
{
    internal class DateTimeParser : IParser
    {
        public bool CanParse(PropertyInfo prop, object propValue)
        {
            var type = prop.PropertyType;

            if (type.GetTypeInfo().IsGenericType && type.GetGenericTypeDefinition() == typeof(Nullable<>))
            {
                type = Nullable.GetUnderlyingType(type);
            }

            return type == typeof(DateTime);
        }

        //ISO8601 as specified in docs
        public string Parse(PropertyInfo prop, object propValue) => ((DateTime)propValue).ToString("o");
    }
}

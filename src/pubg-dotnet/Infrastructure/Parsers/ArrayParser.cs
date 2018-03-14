using System.Collections;
using System.Linq;
using System.Reflection;

namespace Pubg.Net.Infrastructure.Parsers
{
    internal class ArrayParser : IParser
    {
        public bool CanParse(PropertyInfo prop, object propValue) => prop.PropertyType.IsArray;

        public string Parse(PropertyInfo prop, object propValue) => ((IEnumerable)propValue).Cast<object>().Select(x => x.ToString()).Aggregate((x,y) => x + "," + y);
    }
}

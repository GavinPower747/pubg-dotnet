using System.Reflection;

namespace Pubg.Net.Infrastructure.Parsers
{
    public interface IParser
    {
        bool CanParse(PropertyInfo prop, object propValue);
        string Parse(PropertyInfo prop, object propValue);
    }
}

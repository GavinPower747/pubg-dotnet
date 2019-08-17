using Newtonsoft.Json;
using Pubg.Net.Infrastructure.Parsers;
using Pubg.Net.Services;
using System.Linq;
using System.Net;
using System.Reflection;

namespace Pubg.Net.Infrastructure
{
    internal static class RequestBuilder
    {
        static IParser[] _availableParsers = new IParser[]
        {
            new ArrayParser(),
            new EnumParser(),
            new DateTimeParser()
        };

        internal static string BuildRequestUrl(string baseUrl, PubgRequest request)
        {
            var excludedProperties = typeof(PubgRequest).GetRuntimeProperties();
            var completedUrl = baseUrl;

            foreach (var property in request.GetType().GetRuntimeProperties())
            {
                if (excludedProperties.Any(ep => ep.Name.Equals(property.Name))) continue;

                var value = property.GetValue(request, null);
                if (value == null) continue;

                var parser = _availableParsers.FirstOrDefault(p => p.CanParse(property, value));

                var parsedValue = value;

                if (parser != null)
                    parsedValue = parser.Parse(property, value);

                var attribute = property.GetCustomAttribute<JsonPropertyAttribute>();

                completedUrl = ApplyPrimativeValue(completedUrl, attribute.PropertyName, parsedValue.ToString());                               
            }

            return completedUrl;
        }

        private static string ApplyPrimativeValue(string url, string propName, string value)
        {
            var separator = url.Contains("?") ? "&" : "?";

            return $"{url}{separator}{propName}={WebUtility.UrlEncode(value)}";
        }
    }
}

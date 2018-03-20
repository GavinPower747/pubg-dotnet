using Newtonsoft.Json.Serialization;

namespace Pubg.Net.Infrastructure.JsonContractResolvers
{
    public class TelemetryContractResolver : DefaultContractResolver
    {
        public TelemetryContractResolver(string shardId) : base()
        {
            //For some reason the xbox shards use a different naming strategy to the PC shards
            var isXbox = shardId.ToLowerInvariant().Contains("xbox");

            if (isXbox)
                NamingStrategy = new DefaultNamingStrategy();
            else
                NamingStrategy = new CamelCaseNamingStrategy();
        }
    }
}

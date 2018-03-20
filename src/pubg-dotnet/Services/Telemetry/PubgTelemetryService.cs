using Newtonsoft.Json;
using Pubg.Net.Infrastructure;
using Pubg.Net.Infrastructure.JsonContractResolvers;
using Pubg.Net.Services;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Pubg.Net
{
    public class PubgTelemetryService : PubgService
    {
        public virtual IEnumerable<PubgTelemetryEvent> GetTelemetry(PubgAsset asset)
        {
            return GetTelemetry(asset.Url, asset.ShardId);
        }

        public virtual IEnumerable<PubgTelemetryEvent> GetTelemetry(string url, string shardId)
        {
            var collectionJson = HttpRequestor.GetString(url);

            return JsonConvert.DeserializeObject<IEnumerable<PubgTelemetryEvent>>(collectionJson, new JsonSerializerSettings { ContractResolver = new TelemetryContractResolver(shardId) });
        }

        public virtual async Task<IEnumerable<PubgTelemetryEvent>> GetTelemetryAsync(PubgAsset asset, CancellationToken cancellationToken = default(CancellationToken))
        {
            return await GetTelemetryAsync(asset.Url, asset.ShardId, cancellationToken);
        }

        public virtual async Task<IEnumerable<PubgTelemetryEvent>> GetTelemetryAsync(string url, string shardId, CancellationToken cancellationToken = default(CancellationToken))
        {
            var collectionJson = await HttpRequestor.GetStringAsync(url, cancellationToken);

            return JsonConvert.DeserializeObject<IEnumerable<PubgTelemetryEvent>>(collectionJson, new JsonSerializerSettings { ContractResolver = new TelemetryContractResolver(shardId) });
        }
    }
}

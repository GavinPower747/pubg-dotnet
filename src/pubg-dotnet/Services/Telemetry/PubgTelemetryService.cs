using Newtonsoft.Json;
using Pubg.Net.Infrastructure;
using Pubg.Net.Services;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Pubg.Net
{
    public class PubgTelemetryService : PubgService
    {
        public virtual IEnumerable<PubgTelemetryEvent> GetTelemetry(PubgRegion region, PubgAsset asset)
        {
            return GetTelemetry(region, asset.Url);
        }

        public virtual IEnumerable<PubgTelemetryEvent> GetTelemetry(PubgRegion region, string url)
        {
            var collectionJson = HttpRequestor.GetString(url);

            return JsonConvert.DeserializeObject<IEnumerable<PubgTelemetryEvent>>(collectionJson);
        }

        public virtual async Task<IEnumerable<PubgTelemetryEvent>> GetTelemetryAsync(PubgRegion region, PubgAsset asset, CancellationToken cancellationToken = default(CancellationToken))
        {
            return await GetTelemetryAsync(region, asset.Url, cancellationToken);
        }

        public virtual async Task<IEnumerable<PubgTelemetryEvent>> GetTelemetryAsync(PubgRegion region, string url, CancellationToken cancellationToken = default(CancellationToken))
        {
            var collectionJson = await HttpRequestor.GetStringAsync(url, cancellationToken);

            return JsonConvert.DeserializeObject<IEnumerable<PubgTelemetryEvent>>(collectionJson);
        }
    }
}

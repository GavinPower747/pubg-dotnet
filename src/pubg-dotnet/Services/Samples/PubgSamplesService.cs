using JsonApiSerializer;
using Newtonsoft.Json;
using Pubg.Net.Extensions;
using Pubg.Net.Infrastructure;
using Pubg.Net.Models.Samples;
using Pubg.Net.Services;
using Pubg.Net.Values;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Pubg.Net
{
    public class PubgSamplesService : PubgService
    {
        public PubgSamplesService() : base() { }
        public PubgSamplesService(string apiKey) : base(apiKey) { }

        public PubgMatchSample GetMatchSamples(PubgRegion region, string apiKey = null) => GetMatchSamples(region, new GetSamplesRequest { ApiKey = apiKey });

        public PubgMatchSample GetMatchSamples(PubgRegion region, GetSamplesRequest request)
        {
            var url = RequestBuilder.BuildRequestUrl(string.Format(Api.Samples.SamplesEndpoint, region.Serialize()), request);
            var apiKey = string.IsNullOrEmpty(request.ApiKey) ? ApiKey : request.ApiKey;

            var collectionJson = HttpRequestor.GetString(url, apiKey);

            return JsonConvert.DeserializeObject<IEnumerable<PubgMatchSample>>(collectionJson, new JsonApiSerializerSettings()).FirstOrDefault();
        }

        public Task<PubgMatchSample> GetMatchSamplesAsync(PubgRegion region, string apiKey = null, CancellationToken cancellationToken = default(CancellationToken)) 
            => GetMatchSamplesAsync(region, new GetSamplesRequest { ApiKey = apiKey }, cancellationToken);

        public async Task<PubgMatchSample> GetMatchSamplesAsync(PubgRegion region, GetSamplesRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var url = RequestBuilder.BuildRequestUrl(string.Format(Api.Samples.SamplesEndpoint, region.Serialize()), request);
            var apiKey = string.IsNullOrEmpty(request.ApiKey) ? ApiKey : request.ApiKey;

            var collectionJson = await HttpRequestor.GetStringAsync(url, cancellationToken, apiKey);

            return JsonConvert.DeserializeObject<IEnumerable<PubgMatchSample>>(collectionJson, new JsonApiSerializerSettings()).FirstOrDefault();
        }
    }
}

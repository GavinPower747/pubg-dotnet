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

        public PubgMatchSample GetMatchSamples(PubgPlatform platform, string apiKey = null) => GetMatchSamples(platform, new GetSamplesRequest { ApiKey = apiKey });

        public PubgMatchSample GetMatchSamples(PubgPlatform platform, GetSamplesRequest request)
        {
            var url = RequestBuilder.BuildRequestUrl(Api.Samples.SamplesEndpoint(platform), request);
            var apiKey = string.IsNullOrEmpty(request.ApiKey) ? ApiKey : request.ApiKey;

            var collectionJson = HttpRequestor.GetString(url, apiKey);

            return JsonConvert.DeserializeObject<IEnumerable<PubgMatchSample>>(collectionJson, new JsonApiSerializerSettings()).FirstOrDefault();
        }

        public Task<PubgMatchSample> GetMatchSamplesAsync(PubgPlatform platform, string apiKey = null, CancellationToken cancellationToken = default(CancellationToken)) 
            => GetMatchSamplesAsync(platform, new GetSamplesRequest { ApiKey = apiKey }, cancellationToken);

        public async Task<PubgMatchSample> GetMatchSamplesAsync(PubgPlatform platform, GetSamplesRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var url = RequestBuilder.BuildRequestUrl(Api.Samples.SamplesEndpoint(platform), request);
            var apiKey = string.IsNullOrEmpty(request.ApiKey) ? ApiKey : request.ApiKey;

            var collectionJson = await HttpRequestor.GetStringAsync(url, cancellationToken, apiKey).ConfigureAwait(false);

            return JsonConvert.DeserializeObject<IEnumerable<PubgMatchSample>>(collectionJson, new JsonApiSerializerSettings()).FirstOrDefault();
        }
    }
}

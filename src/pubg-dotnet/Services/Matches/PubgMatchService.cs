using Pubg.Net.Services;
using Pubg.Net.Infrastructure;
using Pubg.Net.Values;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Pubg.Net.Extensions;
using Newtonsoft.Json;
using JsonApiSerializer;

namespace Pubg.Net
{
    public class PubgMatchService : PubgService
    {
        public PubgMatchService() : base() { }
        public PubgMatchService(string apiKey) : base(apiKey) { }

        public virtual PubgMatch GetMatch(Region region, string matchId, string apiKey = null)
        {
            var url = string.Format(Api.Matches.MatchesEndpoint + "/{1}", region.Serialize(), matchId);
            apiKey = string.IsNullOrEmpty(apiKey) ? ApiKey : apiKey;

            var matchJson = HttpRequestor.GetString(url, apiKey);

            return JsonConvert.DeserializeObject<PubgMatch>(matchJson, new JsonApiSerializerSettings());
        }

        public async virtual Task<PubgMatch> GetMatchAsync(Region region, string matchId, string apiKey = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            var url = string.Format(Api.Matches.MatchesEndpoint + "/{1}", region.Serialize(), matchId);
            apiKey = string.IsNullOrEmpty(apiKey) ? ApiKey : apiKey;

            var matchJson = await HttpRequestor.GetStringAsync(url, apiKey, cancellationToken);

            return JsonConvert.DeserializeObject<PubgMatch>(matchJson, new JsonApiSerializerSettings());
        }

        public virtual IEnumerable<PubgMatch> GetMatches(Region region, GetPubgMatchRequest request)
        {
            var url = RequestBuilder.BuildRequestUrl(string.Format(Api.Matches.MatchesEndpoint, region.Serialize()), request);
            var apiKey = string.IsNullOrEmpty(request.ApiKey) ? ApiKey : request.ApiKey;

            var collectionJson = HttpRequestor.GetString(url, apiKey);

            return JsonConvert.DeserializeObject<IEnumerable<PubgMatch>>(collectionJson, new JsonApiSerializerSettings());
        }

        public async virtual Task<IEnumerable<PubgMatch>> GetMatchesAsync(Region region, GetPubgMatchRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var url = RequestBuilder.BuildRequestUrl(string.Format(Api.Matches.MatchesEndpoint, region.Serialize()), request);
            var apiKey = string.IsNullOrEmpty(request.ApiKey) ? ApiKey : request.ApiKey;

            var collectionJson = await HttpRequestor.GetStringAsync(url, ApiKey, cancellationToken);

            return JsonConvert.DeserializeObject<IEnumerable<PubgMatch>>(collectionJson, new JsonApiSerializerSettings());
        }
    }
}

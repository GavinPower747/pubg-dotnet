using Pubg.Net.Services;
using Pubg.Net.Infrastructure;
using Pubg.Net.Values;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Pubg.Net
{
    public class PubgMatchService : PubgService
    {
        public PubgMatchService() : base(null) { }
        public PubgMatchService(string apiKey) : base(apiKey) { }

        public virtual PubgMatch GetMatch(string regionId, string matchId, string apiKey = null)
        {
            var url = string.Format(Api.Matches.MatchesEndpoint + "/{1}", regionId, matchId);
            apiKey = string.IsNullOrEmpty(apiKey) ? ApiKey : apiKey;

            var matchJson = HttpRequestor.GetString(url, apiKey);

            return JsonMapper<PubgMatch>.MapObject(matchJson, ResponseRootNode);
        }

        public async virtual Task<PubgMatch> GetMatchAsync(string regionId, string matchId, string apiKey = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            var url = string.Format(Api.Matches.MatchesEndpoint + "/{1}", regionId, matchId);
            apiKey = string.IsNullOrEmpty(apiKey) ? ApiKey : apiKey;

            var matchJson = await HttpRequestor.GetStringAsync(url, apiKey, cancellationToken);

            return JsonMapper<PubgMatch>.MapObject(matchJson, ResponseRootNode);
        }

        public virtual IEnumerable<PubgMatch> GetMatches(string regionId, GetPubgMatchRequest request)
        {
            var url = RequestBuilder.BuildRequestUrl(string.Format(Api.Matches.MatchesEndpoint, regionId), request);
            var apiKey = string.IsNullOrEmpty(request.ApiKey) ? ApiKey : request.ApiKey;

            var collectionJson = HttpRequestor.GetString(url, apiKey);

            return JsonMapper<PubgMatch>.MapCollection(collectionJson, ResponseRootNode);
        }

        public async virtual Task<IEnumerable<PubgMatch>> GetMatchesAsync(string regionId, GetPubgMatchRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var url = RequestBuilder.BuildRequestUrl(string.Format(Api.Matches.MatchesEndpoint, regionId), request);
            var apiKey = string.IsNullOrEmpty(request.ApiKey) ? ApiKey : request.ApiKey;

            var collectionJson = await HttpRequestor.GetStringAsync(url, ApiKey, cancellationToken);

            return JsonMapper<PubgMatch>.MapCollection(collectionJson, ResponseRootNode);
        }
    }
}

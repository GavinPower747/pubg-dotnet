using Newtonsoft.Json;
using Pubg.Net.Infrastructure;
using Pubg.Net.Values;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Pubg.Net
{
    public class PubgMatchService : PubgService
    {
        public PubgMatchService() : base() { }
        public PubgMatchService(string apiKey) : base(apiKey) { }

        public virtual PubgMatch GetMatch(Region region, string matchId)
        {
            var url = string.Format(Api.Matches.MatchesEndpoint + "/{1}", JsonConvert.ToString(region), matchId);

            var matchJson = HttpRequestor.GetString(url, ApiKey);

            return JsonMapper<PubgMatch>.MapObject(matchJson, ResponseRootNode);
        }

        public async virtual Task<PubgMatch> GetMatchAsync(Region region, string matchId, CancellationToken cancellationToken = default(CancellationToken))
        {
            var url = string.Format(Api.Matches.MatchesEndpoint + "/{1}", JsonConvert.ToString(region), matchId);

            var matchJson = await HttpRequestor.GetStringAsync(url, ApiKey, cancellationToken);

            return JsonMapper<PubgMatch>.MapObject(matchJson, ResponseRootNode);
        }

        public virtual IEnumerable<PubgMatch> GetMatches(Region region, GetPubgMatchRequest request)
        {
            var url = string.Format(Api.Matches.MatchesEndpoint, JsonConvert.ToString(region));

            var collectionJson = HttpRequestor.GetString(url, ApiKey);

            return JsonMapper<PubgMatch>.MapCollection(collectionJson, ResponseRootNode);
        }

        public async virtual Task<IEnumerable<PubgMatch>> GetMatchesAsync(Region region, GetPubgMatchRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var url = string.Format(Api.Matches.MatchesEndpoint, JsonConvert.ToString(region));

            var collectionJson = await HttpRequestor.GetStringAsync(url, ApiKey, cancellationToken);

            return JsonMapper<PubgMatch>.MapCollection(collectionJson, ResponseRootNode);
        }
    }
}

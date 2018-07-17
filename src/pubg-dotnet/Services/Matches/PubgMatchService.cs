using Pubg.Net.Services;
using Pubg.Net.Infrastructure;
using Pubg.Net.Values;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Pubg.Net.Extensions;
using Newtonsoft.Json;
using JsonApiSerializer;
using System.Linq;

namespace Pubg.Net
{
    public class PubgMatchService : PubgService
    {
        public PubgMatchService() : base() { }
        public PubgMatchService(string apiKey) : base(apiKey) { }

        public virtual PubgMatch GetMatch(PubgRegion region, string matchId, string apiKey = null)
        {
            var url = Api.Matches.MatchesEndpoint(region, matchId);
            apiKey = string.IsNullOrEmpty(apiKey) ? ApiKey : apiKey;

            var matchJson = HttpRequestor.GetString(url, apiKey);

            return JsonConvert.DeserializeObject<IEnumerable<PubgMatch>>(matchJson, new JsonApiSerializerSettings()).FirstOrDefault();
        }

        public async virtual Task<PubgMatch> GetMatchAsync(PubgRegion region, string matchId, string apiKey = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            var url = string.Format(Api.Matches.MatchesEndpoint + "/{1}", region.Serialize(), matchId);
            apiKey = string.IsNullOrEmpty(apiKey) ? ApiKey : apiKey;

            var matchJson = await HttpRequestor.GetStringAsync(url, cancellationToken, apiKey);

            return JsonConvert.DeserializeObject<IEnumerable<PubgMatch>>(matchJson, new JsonApiSerializerSettings()).FirstOrDefault();
        }
    }
}

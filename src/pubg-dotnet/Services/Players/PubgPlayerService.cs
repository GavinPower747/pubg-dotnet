using JsonApiSerializer;
using Newtonsoft.Json;
using Pubg.Net.Extensions;
using Pubg.Net.Infrastructure;
using Pubg.Net.Services;
using Pubg.Net.Values;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Pubg.Net
{
    public class PubgPlayerService : PubgService
    {
        public PubgPlayerService() : base() { }
        public PubgPlayerService(string apiKey) : base(apiKey) { }

        public virtual PubgPlayer GetPlayer(PubgRegion region, string playerId, string apiKey = null)
        {
            var url = string.Format(Api.Players.PlayersEndpoint + "/{1}", region.Serialize(), playerId);
            apiKey = string.IsNullOrEmpty(apiKey) ? ApiKey : apiKey;

            var playerJson = HttpRequestor.GetString(url, apiKey);

            return JsonConvert.DeserializeObject<PubgPlayer>(playerJson, new JsonApiSerializerSettings());
        }

        public virtual async Task<PubgPlayer> GetPlayerAsync(PubgRegion region, string playerId, string apiKey = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            var url = string.Format(Api.Players.PlayersEndpoint + "/{1}", region.Serialize(), playerId);
            apiKey = string.IsNullOrEmpty(apiKey) ? ApiKey : apiKey;

            var playerJson = await HttpRequestor.GetStringAsync(url, cancellationToken, apiKey);

            return JsonConvert.DeserializeObject<PubgPlayer>(playerJson, new JsonApiSerializerSettings());
        }

        public virtual IEnumerable<PubgPlayer> GetPlayers(PubgRegion region, GetPubgPlayersRequest filter)
        {
            var url = RequestBuilder.BuildRequestUrl(string.Format(Api.Players.PlayersEndpoint, region.Serialize()), filter);
            var apiKey = string.IsNullOrEmpty(filter.ApiKey) ? ApiKey : filter.ApiKey;

            var collectionJson = HttpRequestor.GetString(url, apiKey);

            return JsonConvert.DeserializeObject<IEnumerable<PubgPlayer>>(collectionJson, new JsonApiSerializerSettings());
        }

        public virtual async Task<IEnumerable<PubgPlayer>> GetPlayersAsync(PubgRegion region, GetPubgPlayersRequest filter, CancellationToken cancellationToken = default(CancellationToken))
        {
            var url = RequestBuilder.BuildRequestUrl(string.Format(Api.Players.PlayersEndpoint, region.Serialize()), filter);
            var apiKey = string.IsNullOrEmpty(filter.ApiKey) ? ApiKey : filter.ApiKey;

            var collectionJson = await HttpRequestor.GetStringAsync(url, cancellationToken, apiKey);

            return JsonConvert.DeserializeObject<IEnumerable<PubgPlayer>>(collectionJson, new JsonApiSerializerSettings());
        }
    }
}

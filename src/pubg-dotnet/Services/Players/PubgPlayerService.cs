using JsonApiSerializer;
using Newtonsoft.Json;
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
            var url = Api.Players.PlayersEndpoint(region, playerId);
            apiKey = string.IsNullOrEmpty(apiKey) ? ApiKey : apiKey;

            var playerJson = HttpRequestor.GetString(url, apiKey);

            return JsonConvert.DeserializeObject<PubgPlayer>(playerJson, new JsonApiSerializerSettings());
        }

        public virtual async Task<PubgPlayer> GetPlayerAsync(PubgRegion region, string playerId, string apiKey = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            var url = Api.Players.PlayersEndpoint(region, playerId);
            apiKey = string.IsNullOrEmpty(apiKey) ? ApiKey : apiKey;

            var playerJson = await HttpRequestor.GetStringAsync(url, cancellationToken, apiKey).ConfigureAwait(false);

            return JsonConvert.DeserializeObject<PubgPlayer>(playerJson, new JsonApiSerializerSettings());
        }

        public virtual IEnumerable<PubgPlayer> GetPlayers(PubgRegion region, GetPubgPlayersRequest filter)
        {
            var url = RequestBuilder.BuildRequestUrl(Api.Players.PlayersEndpoint(region), filter);
            var apiKey = string.IsNullOrEmpty(filter.ApiKey) ? ApiKey : filter.ApiKey;

            var collectionJson = HttpRequestor.GetString(url, apiKey);

            return JsonConvert.DeserializeObject<IEnumerable<PubgPlayer>>(collectionJson, new JsonApiSerializerSettings());
        }

        public virtual async Task<IEnumerable<PubgPlayer>> GetPlayersAsync(PubgRegion region, GetPubgPlayersRequest filter, CancellationToken cancellationToken = default(CancellationToken))
        {
            var url = RequestBuilder.BuildRequestUrl(Api.Players.PlayersEndpoint(region), filter);
            var apiKey = string.IsNullOrEmpty(filter.ApiKey) ? ApiKey : filter.ApiKey;

            var collectionJson = await HttpRequestor.GetStringAsync(url, cancellationToken, apiKey).ConfigureAwait(false);

            return JsonConvert.DeserializeObject<IEnumerable<PubgPlayer>>(collectionJson, new JsonApiSerializerSettings());
        }

        public virtual PubgPlayerSeason GetPlayerSeason(PubgRegion region, string playerId, string seasonId, string apiKey = null)
        {
            var url = Api.Players.PlayerSeasonsEndpoint(region, playerId, seasonId);
            apiKey = string.IsNullOrEmpty(apiKey) ? ApiKey : apiKey;

            var seasonJson = HttpRequestor.GetString(url, apiKey);

            return JsonConvert.DeserializeObject<PubgPlayerSeason>(seasonJson, new JsonApiSerializerSettings());
        }

        public async virtual Task<PubgPlayerSeason> GetPlayerSeasonAsync(PubgRegion region, string playerId, string seasonId, string apiKey = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            var url = Api.Players.PlayerSeasonsEndpoint(region, playerId, seasonId);
            apiKey = string.IsNullOrEmpty(apiKey) ? ApiKey : apiKey;

            var seasonJson = await HttpRequestor.GetStringAsync(url, cancellationToken, apiKey).ConfigureAwait(false);

            return JsonConvert.DeserializeObject<PubgPlayerSeason>(seasonJson, new JsonApiSerializerSettings());
        }
    }
}

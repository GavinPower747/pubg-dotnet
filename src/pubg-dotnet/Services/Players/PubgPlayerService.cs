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

        /// <summary>
        ///   Gets the players season stats and matches for the default platform (steam)
        /// </summary>
        /// <param name="playerId">The ID of the player you wish to retrieve the season stats for</param>
        /// <param name="seasonId">The ID of the season you wish to recieve stats and matches for</param>
        /// <param name="apiKey">Your API key (optional)</param>
        /// <returns>Stats and matches for a given player during a given season</returns>
        /// <exception cref="Pubg.Net.Exceptions.PubgException">Exception thrown on the API side, details included on object</exception>
        /// <exception cref="Pubg.Net.Exceptions.PubgNotFoundException">The api is unable to find the specified player</exception>
        /// <exception cref="Pubg.Net.Exceptions.PubgTooManyRequestsException">You have exceeded your rate limit</exception>
        /// <exception cref="Pubg.Net.Exceptions.PubgUnauthorizedException">Invalid API Key</exception>
        public virtual PubgPlayerSeason GetPlayerSeasonPC(string playerId, string seasonId, string apiKey = null) => GetPlayerSeasonPC(PubgPlatform.Steam, playerId, seasonId, apiKey);

        /// <summary>
        ///   Gets the players season stats and matches for the specified platform
        /// </summary>
        /// <param name="platform">The platform on which the season took place</param>
        /// <param name="playerId">The ID of the player you wish to retrieve the season stats for</param>
        /// <param name="seasonId">The ID of the season you wish to recieve stats and matches for</param>
        /// <param name="apiKey">Your API key (optional)</param>
        /// <returns>Stats and matches for a given player during a given season</returns>
        /// <exception cref="Pubg.Net.Exceptions.PubgException">Exception thrown on the API side, details included on object</exception>
        /// <exception cref="Pubg.Net.Exceptions.PubgNotFoundException">The api is unable to find the specified player</exception>
        /// <exception cref="Pubg.Net.Exceptions.PubgTooManyRequestsException">You have exceeded your rate limit</exception>
        /// <exception cref="Pubg.Net.Exceptions.PubgUnauthorizedException">Invalid API Key</exception>
        public virtual PubgPlayerSeason GetPlayerSeasonPC(PubgPlatform platform, string playerId, string seasonId, string apiKey = null)
        {
            var url = Api.Players.PlayerSeasonsPCEndpoint(platform, playerId, seasonId);
            apiKey = string.IsNullOrEmpty(apiKey) ? ApiKey : apiKey;

            var seasonJson = HttpRequestor.GetString(url, apiKey);

            return JsonConvert.DeserializeObject<PubgPlayerSeason>(seasonJson, new JsonApiSerializerSettings());
        }

        /// <summary>
        ///   Gets the players season stats and matches for the specified platform asynchronusly
        /// </summary>
        /// <param name="platform">The platform on which the season took place</param>
        /// <param name="playerId">The ID of the player you wish to retrieve the season stats for</param>
        /// <param name="seasonId">The ID of the season you wish to recieve stats and matches for</param>
        /// <param name="apiKey">Your API key (optional)</param>
        /// <returns>Stats and matches for a given player during a given season</returns>
        /// <exception cref="Pubg.Net.Exceptions.PubgException">Exception thrown on the API side, details included on object</exception>
        /// <exception cref="Pubg.Net.Exceptions.PubgNotFoundException">The api is unable to find the specified player</exception>
        /// <exception cref="Pubg.Net.Exceptions.PubgTooManyRequestsException">You have exceeded your rate limit</exception>
        /// <exception cref="Pubg.Net.Exceptions.PubgUnauthorizedException">Invalid API Key</exception>
        public async virtual Task<PubgPlayerSeason> GetPlayerSeasonPCAsync(PubgPlatform platform, string playerId, string seasonId, string apiKey = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            var url = Api.Players.PlayerSeasonsPCEndpoint(platform, playerId, seasonId);
            apiKey = string.IsNullOrEmpty(apiKey) ? ApiKey : apiKey;

            var seasonJson = await HttpRequestor.GetStringAsync(url, cancellationToken, apiKey).ConfigureAwait(false);

            return JsonConvert.DeserializeObject<PubgPlayerSeason>(seasonJson, new JsonApiSerializerSettings());
        }

        /// <summary>
        ///   Gets the players season stats and matches played on the xbox in the specified region
        /// </summary>
        /// <param name="region">The region which the player is located in</param>
        /// <param name="playerId">The ID of the player you wish to retrieve the season stats for</param>
        /// <param name="seasonId">The ID of the season you wish to recieve stats and matches for</param>
        /// <param name="apiKey">Your API key (optional)</param>
        /// <returns>Stats and matches for a given player during a given season</returns>
        /// <exception cref="Pubg.Net.Exceptions.PubgException">Exception thrown on the API side, details included on object</exception>
        /// <exception cref="Pubg.Net.Exceptions.PubgNotFoundException">The api is unable to find the specified player</exception>
        /// <exception cref="Pubg.Net.Exceptions.PubgTooManyRequestsException">You have exceeded your rate limit</exception>
        /// <exception cref="Pubg.Net.Exceptions.PubgUnauthorizedException">Invalid API Key</exception>
        public virtual PubgPlayerSeason GetPlayerSeasonXbox(PubgRegion region, string playerId, string seasonId, string apiKey = null)
        {
            var url = Api.Players.PlayerSeasonsXboxEndpoint(region, playerId, seasonId);
            apiKey = string.IsNullOrEmpty(apiKey) ? ApiKey : apiKey;

            var seasonJson = HttpRequestor.GetString(url, apiKey);

            return JsonConvert.DeserializeObject<PubgPlayerSeason>(seasonJson, new JsonApiSerializerSettings());
        }

        /// <summary>
        ///   Gets the players season stats and matches played on the xbox in the specified region asychronusly
        /// </summary>
        /// <param name="region">The region which the player is located in</param>
        /// <param name="playerId">The ID of the player you wish to retrieve the season stats for</param>
        /// <param name="seasonId">The ID of the season you wish to recieve stats and matches for</param>
        /// <param name="apiKey">Your API key (optional)</param>
        /// <returns>Stats and matches for a given player during a given season</returns>
        /// <exception cref="Pubg.Net.Exceptions.PubgException">Exception thrown on the API side, details included on object</exception>
        /// <exception cref="Pubg.Net.Exceptions.PubgNotFoundException">The api is unable to find the specified player</exception>
        /// <exception cref="Pubg.Net.Exceptions.PubgTooManyRequestsException">You have exceeded your rate limit</exception>
        /// <exception cref="Pubg.Net.Exceptions.PubgUnauthorizedException">Invalid API Key</exception>
        public async virtual Task<PubgPlayerSeason> GetPlayerSeasonXboxAsync(PubgRegion region, string playerId, string seasonId, string apiKey = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            var url = Api.Players.PlayerSeasonsXboxEndpoint(region, playerId, seasonId);
            apiKey = string.IsNullOrEmpty(apiKey) ? ApiKey : apiKey;

            var seasonJson = await HttpRequestor.GetStringAsync(url, cancellationToken, apiKey).ConfigureAwait(false);

            return JsonConvert.DeserializeObject<PubgPlayerSeason>(seasonJson, new JsonApiSerializerSettings());
        }
    }
}

using Pubg.Net.Services;
using Pubg.Net.Infrastructure;
using Pubg.Net.Values;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Newtonsoft.Json;
using JsonApiSerializer;
using System.Linq;

namespace Pubg.Net
{
    public class PubgMatchService : PubgService
    {
        public PubgMatchService() : base() { }
        public PubgMatchService(string apiKey) : base(apiKey) { }

        /// <summary>
        ///  Get a specified match which was played on the PC from the Api from the default platform (steam)
        /// </summary>
        /// <param name="matchId">The ID for the specified match</param>
        /// <param name="apiKey">Your Api Key (optional, not needed if specified elsewhere)</param>
        /// <returns>PubgMatch object for the specified ID</returns>
        /// <exception cref="Pubg.Net.Exceptions.PubgException">Exception thrown on the API side, details included on object</exception>
        /// <exception cref="Pubg.Net.Exceptions.PubgNotFoundException">The api is unable to find the specified match</exception>
        /// <exception cref="Pubg.Net.Exceptions.PubgTooManyRequestsException">You have exceeded your rate limit</exception>
        /// <exception cref="Pubg.Net.Exceptions.PubgUnauthorizedException">Invalid API Key</exception>
        public virtual PubgMatch GetMatchPC(string matchId, string apiKey = null) => GetMatchPC(PubgPlatform.Steam, matchId, apiKey);

        /// <summary>
        ///  Get a specified match which was played on the PC from the Api from the specified platform
        /// </summary>
        /// <param name="region">The platform the match is on</param>
        /// <param name="matchId">The ID for the specified match</param>
        /// <param name="apiKey">Your Api Key (optional, not needed if specified elsewhere)</param>
        /// <returns>PubgMatch object for the specified ID</returns>
        /// <exception cref="Pubg.Net.Exceptions.PubgException">Exception thrown on the API side, details included on object</exception>
        /// <exception cref="Pubg.Net.Exceptions.PubgNotFoundException">The api is unable to find the specified match</exception>
        /// <exception cref="Pubg.Net.Exceptions.PubgTooManyRequestsException">You have exceeded your rate limit</exception>
        /// <exception cref="Pubg.Net.Exceptions.PubgUnauthorizedException">Invalid API Key</exception>
        public virtual PubgMatch GetMatchPC(PubgPlatform platform, string matchId, string apiKey = null)
        {
            var url = Api.Matches.MatchesPCEndpoint(platform, matchId);
            apiKey = string.IsNullOrEmpty(apiKey) ? ApiKey : apiKey;

            var matchJson = HttpRequestor.GetString(url, apiKey);

            return JsonConvert.DeserializeObject<IEnumerable<PubgMatch>>(matchJson, new JsonApiSerializerSettings()).FirstOrDefault();
        }

        /// <summary>
        ///  Get a specified match which was played on the PC from the Api from the specified platform asychronously
        /// </summary>
        /// <param name="region">The platform the match is on</param>
        /// <param name="matchId">The ID for the specified match</param>
        /// <param name="apiKey">Your Api Key (optional, not needed if specified elsewhere)</param>
        /// <returns>PubgMatch object for the specified ID</returns>
        /// <exception cref="Pubg.Net.Exceptions.PubgException">Exception thrown on the API side, details included on object</exception>
        /// <exception cref="Pubg.Net.Exceptions.PubgNotFoundException">The api is unable to find the specified match</exception>
        /// <exception cref="Pubg.Net.Exceptions.PubgTooManyRequestsException">You have exceeded your rate limit</exception>
        /// <exception cref="Pubg.Net.Exceptions.PubgUnauthorizedException">Invalid API Key</exception>
        public async virtual Task<PubgMatch> GetMatchPCAsync(PubgPlatform region, string matchId, string apiKey = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            var url = Api.Matches.MatchesPCEndpoint(region, matchId);
            apiKey = string.IsNullOrEmpty(apiKey) ? ApiKey : apiKey;

            var matchJson = await HttpRequestor.GetStringAsync(url, cancellationToken, apiKey).ConfigureAwait(false);

            return JsonConvert.DeserializeObject<IEnumerable<PubgMatch>>(matchJson, new JsonApiSerializerSettings()).FirstOrDefault();
        }

        /// <summary>
        ///  Get a specified match which was played on the Xbox from the Api from the specified platform
        /// </summary>
        /// <param name="region">The region the match is held in</param>
        /// <param name="matchId">The ID for the specified match</param>
        /// <param name="apiKey">Your Api Key (optional, not needed if specified elsewhere)</param>
        /// <returns>PubgMatch object for the specified ID</returns>
        /// <exception cref="Pubg.Net.Exceptions.PubgException">Exception thrown on the API side, details included on object</exception>
        /// <exception cref="Pubg.Net.Exceptions.PubgNotFoundException">The api is unable to find the specified match</exception>
        /// <exception cref="Pubg.Net.Exceptions.PubgTooManyRequestsException">You have exceeded your rate limit</exception>
        /// <exception cref="Pubg.Net.Exceptions.PubgUnauthorizedException">Invalid API Key</exception>
        public virtual PubgMatch GetMatchXbox(PubgRegion region, string matchId, string apiKey = null)
        {
            var url = Api.Matches.MatchesXboxEndpoint(region, matchId);
            apiKey = string.IsNullOrEmpty(apiKey) ? ApiKey : apiKey;

            var matchJson = HttpRequestor.GetString(url, apiKey);

            return JsonConvert.DeserializeObject<IEnumerable<PubgMatch>>(matchJson, new JsonApiSerializerSettings()).FirstOrDefault();
        }

        /// <summary>
        ///  Get a specified match which was played on the Xbox from the Api from the specified platform asychronously
        /// </summary>
        /// <param name="region">The region the match is held in</param>
        /// <param name="matchId">The ID for the specified match</param>
        /// <param name="apiKey">Your Api Key (optional, not needed if specified elsewhere)</param>
        /// <returns>PubgMatch object for the specified ID</returns>
        /// <exception cref="Pubg.Net.Exceptions.PubgException">Exception thrown on the API side, details included on object</exception>
        /// <exception cref="Pubg.Net.Exceptions.PubgNotFoundException">The api is unable to find the specified match</exception>
        /// <exception cref="Pubg.Net.Exceptions.PubgTooManyRequestsException">You have exceeded your rate limit</exception>
        /// <exception cref="Pubg.Net.Exceptions.PubgUnauthorizedException">Invalid API Key</exception>
        public async virtual Task<PubgMatch> GetMatchXboxAsync(PubgRegion region, string matchId, string apiKey = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            var url = Api.Matches.MatchesXboxEndpoint(region, matchId);
            apiKey = string.IsNullOrEmpty(apiKey) ? ApiKey : apiKey;

            var matchJson = await HttpRequestor.GetStringAsync(url, cancellationToken, apiKey).ConfigureAwait(false);

            return JsonConvert.DeserializeObject<IEnumerable<PubgMatch>>(matchJson, new JsonApiSerializerSettings()).FirstOrDefault();
        }
    }
}

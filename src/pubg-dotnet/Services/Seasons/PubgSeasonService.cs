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
    public class PubgSeasonService : PubgService
    {
        public PubgSeasonService() : base() { }
        public PubgSeasonService(string apiKey) : base(apiKey) { }

        /// <summary>
        ///  Get a list of seasons for the specified platform on the PC (default: Steam)
        /// </summary>
        /// <param name="platform">The platform you wish to get the seasons for</param>
        /// <param name="apiKey">Your api key (optional)</param>
        /// <returns>A list of seasons and their information</returns>
        /// <exception cref="Pubg.Net.Exceptions.PubgException">Exception thrown on the API side, details included on object</exception>
        /// <exception cref="Pubg.Net.Exceptions.PubgTooManyRequestsException">You have exceeded your rate limit</exception>
        /// <exception cref="Pubg.Net.Exceptions.PubgUnauthorizedException">Invalid API Key</exception>
        public virtual IEnumerable<PubgSeason> GetSeasons(PubgPlatform platform = PubgPlatform.Steam, string apiKey = null)
        {
            var url = Api.Seasons.SeasonsPCEndpoint(platform);
            apiKey = string.IsNullOrEmpty(apiKey) ? ApiKey : apiKey;

            var seasonJson = HttpRequestor.GetString(url, apiKey);

            return JsonConvert.DeserializeObject<IEnumerable<PubgSeason>>(seasonJson, new JsonApiSerializerSettings());
        }

        /// <summary>
        ///  Get a list of seasons for the specified platform on the PC (default: Steam)
        /// </summary>
        /// <param name="platform">The platform you wish to get the seasons for</param>
        /// <param name="apiKey">Your api key (optional)</param>
        /// <returns>A list of seasons and their information</returns>
        /// <exception cref="Pubg.Net.Exceptions.PubgException">Exception thrown on the API side, details included on object</exception>
        /// <exception cref="Pubg.Net.Exceptions.PubgTooManyRequestsException">You have exceeded your rate limit</exception>
        /// <exception cref="Pubg.Net.Exceptions.PubgUnauthorizedException">Invalid API Key</exception>
        public async virtual Task<IEnumerable<PubgSeason>> GetSeasonsAsync(PubgPlatform platform = PubgPlatform.Steam, string apiKey = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            var url = Api.Seasons.SeasonsPCEndpoint(platform);
            apiKey = string.IsNullOrEmpty(apiKey) ? ApiKey : apiKey;

            var seasonJson = await HttpRequestor.GetStringAsync(url, cancellationToken, apiKey).ConfigureAwait(false);

            return JsonConvert.DeserializeObject<IEnumerable<PubgSeason>>(seasonJson, new JsonApiSerializerSettings());
        }
    }
}

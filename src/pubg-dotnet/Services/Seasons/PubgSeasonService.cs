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
    public class PubgSeasonService : PubgService
    {
        public PubgSeasonService() : base() { }
        public PubgSeasonService(string apiKey) : base(apiKey) { }

        public virtual IEnumerable<PubgSeason> GetSeasons(PubgRegion region, string apiKey = null)
        {
            var url = string.Format(Api.Seasons.SeasonsEndpoint, region.Serialize());
            apiKey = string.IsNullOrEmpty(apiKey) ? ApiKey : apiKey;

            var seasonJson = HttpRequestor.GetString(url, apiKey);

            return JsonConvert.DeserializeObject<IEnumerable<PubgSeason>>(seasonJson, new JsonApiSerializerSettings());
        }

        public async virtual Task<IEnumerable<PubgSeason>> GetSeasonsAsync(PubgRegion region, string apiKey = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            var url = string.Format(Api.Seasons.SeasonsEndpoint, region.Serialize());
            apiKey = string.IsNullOrEmpty(apiKey) ? ApiKey : apiKey;

            var seasonJson = await HttpRequestor.GetStringAsync(url, cancellationToken, apiKey);

            return JsonConvert.DeserializeObject<IEnumerable<PubgSeason>>(seasonJson, new JsonApiSerializerSettings());
        }
    }
}

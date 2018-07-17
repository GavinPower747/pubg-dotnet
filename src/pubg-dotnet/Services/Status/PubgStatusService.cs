using JsonApiSerializer;
using Newtonsoft.Json;
using Pubg.Net.Infrastructure;
using Pubg.Net.Services;
using Pubg.Net.Values;
using System.Threading;
using System.Threading.Tasks;

namespace Pubg.Net
{
    public class PubgStatusService : PubgService
    {
        public PubgStatusService() : base() { }
        public PubgStatusService(string apiKey) : base(apiKey) { }

        public virtual PubgStatus GetStatus(string apiKey = null)
        {
            var url = Api.Status.StatusEndpoint();
            apiKey = string.IsNullOrEmpty(apiKey) ? ApiKey : apiKey;

            var objectJson = HttpRequestor.GetString(url, apiKey);

            return JsonConvert.DeserializeObject<PubgStatus>(objectJson, new JsonApiSerializerSettings());
        }

        public virtual async Task<PubgStatus> GetStatusAsync(string apiKey = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            var url = Api.Status.StatusEndpoint();
            apiKey = string.IsNullOrEmpty(apiKey) ? ApiKey : apiKey;

            var objectJson = await HttpRequestor.GetStringAsync(url, cancellationToken, apiKey).ConfigureAwait(false);

            return JsonConvert.DeserializeObject<PubgStatus>(objectJson, new JsonApiSerializerSettings());
        }
    }
}

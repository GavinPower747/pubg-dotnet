using Pubg.Net.Infrastructure;
using Pubg.Net.Services;
using Pubg.Net.Values;
using System.Threading;
using System.Threading.Tasks;

namespace Pubg.Net
{
    public class PubgStatusService : PubgService
    {
        public PubgStatusService() : base(null) { }
        public PubgStatusService(string apiKey) : base(apiKey) { }

        public PubgStatus GetStatus(string apiKey = null)
        {
            var url = Api.Status.StatusEndpoint;
            apiKey = string.IsNullOrEmpty(apiKey) ? ApiKey : apiKey;

            var objectJson = HttpRequestor.GetString(url, apiKey);

            return JsonMapper<PubgStatus>.MapObject(objectJson, ResponseRootNode);
        }

        public async Task<PubgStatus> GetStatusAsync(string apiKey = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            var url = Api.Status.StatusEndpoint;
            apiKey = string.IsNullOrEmpty(apiKey) ? ApiKey : apiKey;

            var objectJson = await HttpRequestor.GetStringAsync(url, apiKey, cancellationToken);

            return JsonMapper<PubgStatus>.MapObject(objectJson, ResponseRootNode);
        }
    }
}

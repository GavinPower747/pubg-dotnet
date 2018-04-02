using Newtonsoft.Json;
using Pubg.Net.Services;

namespace Pubg.Net
{
    public class GetPubgPlayersRequest : PubgRequest
    {
        [JsonProperty("filter[playerIds]")]
        public string[] PlayerIds { get; set; }

        [JsonProperty("filter[playerNames]")]
        public string[] PlayerNames { get; set; }
    }
}

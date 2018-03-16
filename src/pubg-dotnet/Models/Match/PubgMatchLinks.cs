using Newtonsoft.Json;

namespace Pubg.Net
{
    public class PubgMatchLinks
    {
        [JsonProperty("next")]
        public string Next { get; set; }

        [JsonProperty("self")]
        public string Self { get; set; }
    }
}

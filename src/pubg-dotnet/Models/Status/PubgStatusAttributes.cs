using Newtonsoft.Json;

namespace Pubg.Net
{
    public class PubgStatusAttributes
    {
        [JsonProperty]
        public string ReleasedAt { get; set; }

        [JsonProperty]
        public string Version { get; set; }
    }
}

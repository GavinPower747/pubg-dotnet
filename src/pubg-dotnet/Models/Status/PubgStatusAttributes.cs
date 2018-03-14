using Newtonsoft.Json;

namespace Pubg.Net
{
    public class PubgStatusAttributes
    {
        [JsonProperty("releasedAt")]
        public string ReleasedAt { get; set; }

        [JsonProperty("version")]
        public string Version { get; set; }
    }
}

using Newtonsoft.Json;

namespace Pubg.Net.Models.Errors
{
    public class PubgErrorSource
    {
        [JsonProperty]
        public string Pointer { get; set; }

        [JsonProperty]
        public string Parameter { get; set; }
    }
}

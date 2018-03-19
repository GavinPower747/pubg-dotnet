using Newtonsoft.Json;
using Pubg.Net.Models.Base;

namespace Pubg.Net.Models.Errors
{
    public class PubgError : PubgEntity
    {
        [JsonProperty]
        public string Status { get; set; }

        [JsonProperty]
        public string Code { get; set; }
        
        [JsonProperty]
        public string Title { get; set; }

        [JsonProperty]
        public string Detail { get; set; }

        [JsonProperty]
        public PubgErrorSource Source { get; set; }
    }
}

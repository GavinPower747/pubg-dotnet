using Newtonsoft.Json;

namespace Pubg.Net.Models.Base
{
    public abstract class PubgEntity
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }
}

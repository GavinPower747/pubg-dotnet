using Newtonsoft.Json;

namespace Pubg.Net.Models.Base
{
    public abstract class PubgEntity
    {
        [JsonProperty]
        public string Id { get; set; }
    }
}

using Newtonsoft.Json;
using Pubg.Net.Models.Base;

namespace Pubg.Net
{
    public class PubgStatus : PubgEntity
    {
        [JsonProperty("attributes")]
        public PubgStatusAttributes Attributes { get; set; }
    }
}

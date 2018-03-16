using Newtonsoft.Json;
using Pubg.Net.Models.Base;

namespace Pubg.Net
{
    public class PubgStatus : PubgEntity
    {
        [JsonProperty]
        public PubgStatusAttributes Attributes { get; set; }
    }
}

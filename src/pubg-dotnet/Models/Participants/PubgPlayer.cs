using Newtonsoft.Json;
using Pubg.Net.Models.Base;

namespace Pubg.Net
{
    public class PubgPlayer : PubgEntity
    {
        [JsonProperty]
        public string Name { get; set; }

        [JsonProperty]
        public string PatchVersion { get; set; }

        [JsonProperty]
        public string TitleId { get; set; }
    }
}

using Newtonsoft.Json;
using System.Collections.Generic;

namespace Pubg.Net
{
    public class PubgItemPackage
    {
        [JsonProperty]
        public string ItemPackageId { get; set; }

        [JsonProperty]
        public Location Location { get; set; }

        [JsonProperty]
        public IEnumerable<PubgItem> Items { get; set; }
    }
}

using Newtonsoft.Json;
using Pubg.Net.Services;
using System;

namespace Pubg.Net
{
    public class GetSamplesRequest : PubgRequest
    {
        [JsonProperty("filter[createdAt-start]")]
        public DateTime? CreatedAtStart { get; set; }
    }
}

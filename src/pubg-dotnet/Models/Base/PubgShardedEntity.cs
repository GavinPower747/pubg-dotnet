using Newtonsoft.Json;

namespace Pubg.Net.Models.Base
{
    public abstract class PubgShardedEntity : PubgEntity
    {
        [JsonProperty]
        public string ShardId { get; set; }
    }
}

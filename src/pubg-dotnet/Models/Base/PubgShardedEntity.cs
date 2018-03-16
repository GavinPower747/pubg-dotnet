using Newtonsoft.Json;

namespace Pubg.Net.Models.Base
{
    public abstract class PubgShardedEntity : PubgEntity
    {
        [JsonProperty("attributes.shardId")]
        public string ShardId { get; set; }
    }
}

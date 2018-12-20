using Newtonsoft.Json;
using Pubg.Net.Models.Base;

namespace Pubg.Net
{
    public class PubgLeaderboardPlayer : PubgShardedEntity
    {
        [JsonProperty]
        public string Name { get; set; }

        [JsonProperty]
        public int Rank { get; set; }

        [JsonProperty]
        public PubgLeaderboardStats Stats { get; set; }
    }
}

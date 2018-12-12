using Newtonsoft.Json;
using Pubg.Net.Models.Base;
using System.Collections.Generic;

namespace Pubg.Net
{
    public class PubgLeaderboard : PubgShardedEntity
    {
        [JsonProperty]
        public PubgGameMode GameMode { get; set; }

        [JsonProperty]
        public IEnumerable<PubgLeaderboardPlayer> Players { get; set; }
    }
}

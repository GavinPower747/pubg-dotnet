using Newtonsoft.Json;

namespace Pubg.Net
{
    public class PubgLeaderboardStats
    {
        [JsonProperty]
        public int AverageDamage { get; set; }

        [JsonProperty]
        public float AverageRank { get; set; }

        [JsonProperty]
        public int Games { get; set; }

        [JsonProperty]
        public int Kills { get; set; }

        [JsonProperty]
        public float KillDeathRatio { get; set; }

        [JsonProperty]
        public float RankPoints { get; set; }

        [JsonProperty]
        public float WinRatio { get; set; }

        [JsonProperty]
        public int Wins { get; set; }
    }
}

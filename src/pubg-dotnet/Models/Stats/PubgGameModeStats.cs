using Newtonsoft.Json;

namespace Pubg.Net.Models.Stats
{
    public class PubgGameModeStats
    {
        [JsonProperty]
        public int Assists { get; set; }

        [JsonProperty]
        public int Boosts { get; set; }

        [JsonProperty]
        public int DBNOs { get; set; }

        [JsonProperty]
        public int DailyKills { get; set; }

        [JsonProperty]
        public float DamageDealt { get; set; }

        [JsonProperty]
        public int Days { get; set; }

        [JsonProperty]
        public int HeadshotKills { get; set; }

        [JsonProperty]
        public int Heals { get; set; }

        [JsonProperty]
        public float KillPoints { get; set; }

        [JsonProperty]
        public int Kills { get; set; }

        [JsonProperty]
        public float LongestKill { get; set; }

        [JsonProperty]
        public float LongestTimeSurvived { get; set; }

        [JsonProperty]
        public int Losses { get; set; }

        [JsonProperty]
        public int MaxKillStreaks { get; set; }

        [JsonProperty]
        public float MostSurvivalTime { get; set; }

        [JsonProperty]
        public int Revives { get; set; }

        [JsonProperty]
        public float RideDistance { get; set; }

        [JsonProperty]
        public int RoadKills { get; set; }

        [JsonProperty]
        public int RoundMostKills { get; set; }

        [JsonProperty]
        public int RoundsPlayed { get; set; }

        [JsonProperty]
        public int Suicides { get; set; }

        [JsonProperty]
        public int TeamKills { get; set; }

        [JsonProperty]
        public float TimeSurvived { get; set; }

        [JsonProperty]
        public int Top10s { get; set; }

        [JsonProperty]
        public int VehicleDestroys { get; set; }

        [JsonProperty]
        public float WalkDistance { get; set; }

        [JsonProperty]
        public int WeaponAcquired { get; set; }

        [JsonProperty]
        public int WeeklyKills { get; set; }

        [JsonProperty]
        public float WinPoints { get; set; }

        [JsonProperty]
        public float WinRatio { get; set; }

        [JsonProperty]
        public int Wins { get; set; }
    }
}

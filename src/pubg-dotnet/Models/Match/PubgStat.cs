using Newtonsoft.Json;

namespace Pubg.Net
{
    public class PubgStat
    {
        [JsonProperty("DBNOs")]
        public int DBNOs { get; set; }

        [JsonProperty("assists")]
        public int Assists { get; set; }

        [JsonProperty("boosts")]
        public int Boosts { get; set; }

        [JsonProperty("damageDealt")]
        public double DamageDealt { get; set; }

        [JsonProperty("deathType")]
        public string deathType { get; set; }

        [JsonProperty("headshotKills")]
        public int HeadshotKills { get; set; }

        [JsonProperty("heals")]
        public int Heals { get; set; }

        [JsonProperty("killPlace")]
        public int KillPlace { get; set; }

        [JsonProperty("killPointsDelta")]
        public int KillPointsDelta { get; set; }

        [JsonProperty("kills")]
        public int Kills { get; set; }

        [JsonProperty("lastKillPoints")]
        public int LastKillPoints { get; set; }

        [JsonProperty("lastWinPoints")]
        public int LastWinPoints { get; set; }

        [JsonProperty("longestKill")]
        public double LongestKill { get; set; }

        [JsonProperty("mostDamage")]
        public int MostDamage { get; set; } //Might be double, sample data is all 0.

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("playerId")]
        public string PlayerId { get; set; }

        [JsonProperty("revives")]
        public int Revives { get; set; }

        [JsonProperty("rideDistance")]
        public double RideDistance { get; set; }

        [JsonProperty("roadKills")]
        public int RoadKills { get; set; }

        [JsonProperty("teamKills")]
        public int TeamKills { get; set; }

        [JsonProperty("timeSurvived")]
        public double TimeSurvived { get; set; }

        [JsonProperty("vehicleDestroys")]
        public int VehicleDestroys { get; set; }

        [JsonProperty("walkDistance")]
        public double WalkDistance { get; set; }

        [JsonProperty("weaponsAcquired")]
        public int WeaponsAcquired { get; set; }

        [JsonProperty("winPlace")]
        public int WinPlace { get; set; }

        [JsonProperty("WinPlaceDelta")]
        public int WinPlaceDelta { get; set; }
    }
}

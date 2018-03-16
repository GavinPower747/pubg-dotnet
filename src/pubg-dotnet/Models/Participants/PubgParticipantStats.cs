using Newtonsoft.Json;

namespace Pubg.Net
{
    public class PubgParticipantStats
    {
        [JsonProperty]
        public int DBNOs { get; set; }

        [JsonProperty("assists")]
        public int Assists { get; set; }

        [JsonProperty("boosts")]
        public int Boosts { get; set; }

        [JsonProperty("damageDealt")]
        public int DamageDealt { get; set; }

        [JsonProperty("deathType")]
        public string DeathType { get; set; }

        [JsonProperty("headshotKills")]
        public int HeadshotKills { get; set; }

        [JsonProperty("heals")]
        public int Heals { get; set; }

        [JsonProperty("killPlace")]
        public int KillPlace { get; set; }

        [JsonProperty("killPointsDelta")]
        public int KillPointsDelta { get; set; }

        [JsonProperty("killStreaks")]
        public int KillStreaks { get; set; }

        [JsonProperty("kills")]
        public int Kills { get; set; }

        [JsonProperty("lastKillPoints")]
        public int LastKillPoints { get; set; }

        [JsonProperty("lastWinPoints")]
        public int LastWinPoints { get; set; }

        [JsonProperty("longestKill")]
        public int LongestKill { get; set; }

        [JsonProperty("mostDamage")]
        public int MostDamage { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("playerId")]
        public string PlayerId { get; set; }

        [JsonProperty("revives")]
        public int Revives { get; set; }

        [JsonProperty("rideDistance")]
        public int RideDistance { get; set; }

        [JsonProperty("roadKills")]
        public int RoadKills { get; set; }

        [JsonProperty("teamKills")]
        public int TeamKills { get; set; }

        [JsonProperty("timeSurvived")]
        public int TimeSurvived { get; set; }

        [JsonProperty("vehicleDestroys")]
        public int VehicleDestroys { get; set; }

        [JsonProperty("walkDistance")]
        public int WalkDistance { get; set; }

        [JsonProperty("weaponsAcquired")]
        public int WeaponsAcquired { get; set; }

        [JsonProperty("winPlace")]
        public int WinPlace { get; set; }

        [JsonProperty("winPointsDelta")]
        public int WinPointsDelta { get; set; }
    }
}

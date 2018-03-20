using Newtonsoft.Json;

namespace Pubg.Net
{
    public class PubgGameState
    {
        [JsonProperty]
        public int ElapsedTime { get; set; }

        [JsonProperty]
        public int NumAliveTeams { get; set; }

        [JsonProperty]
        public int NumJoinPlayers { get; set; }

        [JsonProperty]
        public int NumStartPlayers { get; set; }

        [JsonProperty]
        public int NumAlivePlayers { get; set; }

        [JsonProperty]
        public Location SafetyZonePosition { get; set; }

        [JsonProperty]
        public float SafetyZoneRadius { get; set; }

        [JsonProperty]
        public Location PoisonGasWarningPosition { get; set; }

        [JsonProperty]
        public float PoisonGasWarningRadius { get; set; }

        [JsonProperty]
        public Location RedZonePosition { get; set; }

        [JsonProperty]
        public float RedZoneRadius { get; set; }
    }
}

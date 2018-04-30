using Newtonsoft.Json;

namespace Pubg.Net.Models.Stats
{
    public class PubgSeasonStats
    {
        [JsonProperty]
        public PubgGameModeStats Duo { get; set; }

        [JsonProperty("duo-fpp")]
        public PubgGameModeStats DuoFPP { get; set; }

        [JsonProperty]
        public PubgGameModeStats Solo { get; set; }

        [JsonProperty("solo-fpp")]
        public PubgGameModeStats SoloFPP { get; set; }

        [JsonProperty]
        public PubgGameModeStats Squad { get; set; }

        [JsonProperty("squad-fpp")]
        public PubgGameModeStats SquadFPP { get; set; }
    }
}

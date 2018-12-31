using Newtonsoft.Json;

namespace Pubg.Net.Models.Telemetry.Events
{
    public class LogVaultStart
    {
        [JsonProperty]
        public PubgCharacter Character { get; set; }
    }
}

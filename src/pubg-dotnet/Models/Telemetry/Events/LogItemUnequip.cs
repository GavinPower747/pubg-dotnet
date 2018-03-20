using Newtonsoft.Json;

namespace Pubg.Net
{
    public class LogItemUnequip
    {
        [JsonProperty]
        public PubgCharacter Character { get; set; }

        [JsonProperty]
        public PubgItem Item { get; set; }
    }
}

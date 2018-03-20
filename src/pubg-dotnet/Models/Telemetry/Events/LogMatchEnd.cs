using Newtonsoft.Json;
using System.Collections.Generic;

namespace Pubg.Net.Models.Telemetry.Events
{
    public class LogMatchEnd : PubgTelemetryEvent
    {
        [JsonProperty]
        public IEnumerable<PubgCharacter> Characters { get; set; }
    }
}

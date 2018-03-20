using Newtonsoft.Json;
using System.Collections.Generic;

namespace Pubg.Net.Models.Telemetry.Events
{
    public class LogMatchStart : PubgTelemetryEvent
    {
        public IEnumerable<PubgCharacter> Characters { get; set; }
    }
}

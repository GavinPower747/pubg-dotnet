using Newtonsoft.Json.Linq;

namespace Pubg.Net.Models.Telemetry.Events
{
    /// <summary>
    ///     Generic object for when the library can't identify an event
    ///     RawContent contains the serialized json, used for graceful failure.
    /// </summary>
    public class UnknownTelemetryEvent : PubgTelemetryEvent
    {
        public string ErrorMessage => "Unable to identify telemetry event, please create an issue at https://www.github.com/GavinPower747/Pubg-Dotnet/issues";
        public string RawContent { get; set; }

        public UnknownTelemetryEvent(JObject json)
        {
            RawContent = json.ToString();
        }
    }
}

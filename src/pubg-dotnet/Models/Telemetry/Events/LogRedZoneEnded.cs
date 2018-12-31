namespace Pubg.Net.Models.Telemetry.Events
{
    public class LogRedZoneEnded : PubgTelemetryEvent 
    {
        public PubgCharacter[] Drivers { get; set; }
    }
}

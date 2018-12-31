namespace Pubg.Net.Models.Telemetry.Events
{
    public class LogItemPickUpFromCarePackage : PubgTelemetryEvent
    {
        public PubgCharacter Character { get; set; }
        public PubgItem Item { get; set; }
    }
}

namespace Pubg.Net.Models.Telemetry.Events
{
    public class LogParachuteLanding : PubgTelemetryEvent
    {
        public PubgCharacter Character { get; set; }
        public float Distance { get; set; }
    }
}

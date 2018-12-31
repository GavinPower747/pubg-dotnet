namespace Pubg.Net.Models.Telemetry.Events
{
    public class LogHeal: PubgTelemetryEvent
    {
        public PubgCharacter Character { get; set; }
        public PubgItem Item { get; set; }
        public float HealAmount { get; set; }
    }
}

namespace Pubg.Net.Models.Telemetry.Events
{
    public class LogObjectDestroy : PubgTelemetryEvent
    {
        public PubgCharacter Character { get; set; }
        public string ObjectType { get; set; }
        public Location ObjectLocation { get; set; }
    }
}

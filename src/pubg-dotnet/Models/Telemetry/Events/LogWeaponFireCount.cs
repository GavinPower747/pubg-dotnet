namespace Pubg.Net.Models.Telemetry.Events
{
    public class LogWeaponFireCount : PubgTelemetryEvent
    {
        public PubgCharacter Character { get; set; }
        public string WeaponId { get; set; }
        public int FireCount { get; set; }
    }
}

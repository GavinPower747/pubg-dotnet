namespace Pubg.Net.Models.Telemetry.Events
{
    public class LogItemPickupFromLootBox
    {
        public PubgCharacter Character { get; set; }
        public PubgItem Item { get; set; }
        public int OwnerTeamId { get; set; }
    }
}

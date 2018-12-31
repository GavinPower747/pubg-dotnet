namespace Pubg.Net.Models.Telemetry
{
    public class PubgGameResult
    {
        public int Rank { get; set; }
        public string GameResult { get; set; }
        public int TeamId { get; set; }
        public PubgTelemetryStats Stats { get; set; }
        public string AccountId { get; set; }
    }
}

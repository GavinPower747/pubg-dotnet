namespace Pubg.Net.Values
{
    internal static class Api
    {
        internal const string DefaultBaseUrl = "https://api.playbattlegrounds.com";
        internal static string ShardedBaseUrl = PubgApiConfiguration.GetApiBase() + "/shards/{0}";

        internal static class Matches
        {
            internal static string MatchesEndpoint = ShardedBaseUrl + "/matches";
        }

        internal static class Status
        {
            internal static string StatusEndpoint = PubgApiConfiguration.GetApiBase() + "/status";
        }

        internal static class Players
        {
            internal static string PlayersEndpoint = ShardedBaseUrl + "/players";
        }

        internal static class Samples
        {
            internal static string SamplesEndpoint = ShardedBaseUrl + "/samples";
        }
    }
}

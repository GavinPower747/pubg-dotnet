namespace Pubg.Net.Values
{
    internal static class Api
    {
        internal const string DefaultBaseUrl = "https://api.playbattlegrounds.com/shards/{0}";

        internal static class Matches
        {
            internal static string MatchesEndpoint = PubgApiConfiguration.GetApiBase() + "/matches";
        }

        internal static class Status
        {
            internal static string StatusEndpoint = PubgApiConfiguration.GetApiBase() + "/status";
        }

    }
}

using Pubg.Net.Extensions;

namespace Pubg.Net.Values
{
    internal static class Api
    {
        internal const string DefaultBaseUrl = "https://api.playbattlegrounds.com";
        internal static string ShardedBaseUrl = PubgApiConfiguration.GetApiBase() + "/shards/{0}";

        internal static class Matches
        {
            internal static string MatchesEndpoint(PubgRegion region) => string.Format(ShardedBaseUrl + "/matches", region.Serialize());
            internal static string MatchesEndpoint(PubgRegion region, string matchId) => MatchesEndpoint(region) + $"/{matchId}";
        }

        internal static class Status
        {
            internal static string StatusEndpoint() => PubgApiConfiguration.GetApiBase() + "/status";
        }

        internal static class Players
        {
            internal static string PlayersEndpoint(PubgRegion region) => string.Format(ShardedBaseUrl + "/players", region.Serialize());
            internal static string PlayersEndpoint(PubgRegion region, string playerId) => PlayersEndpoint(region) + $"/{playerId}";
            internal static string PlayerSeasonsEndpoint(PubgRegion region, string playerId, string seasonId) => PlayersEndpoint(region) + $"/{playerId}/seasons/{seasonId}";
        }

        internal static class Samples
        {
            internal static string SamplesEndpoint(PubgRegion region) => string.Format(ShardedBaseUrl + "/samples", region.Serialize());
        }

        internal static class Seasons
        {
            internal static string SeasonsEndpoint(PubgRegion region) => string.Format(ShardedBaseUrl + "/seasons", region.Serialize());
        }
    }
}

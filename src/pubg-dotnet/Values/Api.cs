using Pubg.Net.Extensions;

namespace Pubg.Net.Values
{
    internal static class Api
    {
        internal const string DefaultBaseUrl = "https://api.pubg.com";
        internal static string ShardedBaseUrl = PubgApiConfiguration.GetApiBase() + "/shards/{0}";

        internal static class Matches
        {
            internal static string MatchesPCEndpoint(PubgPlatform platform) => string.Format(ShardedBaseUrl + "/matches", platform.Serialize());
            internal static string MatchesPCEndpoint(PubgPlatform platform, string matchId) => MatchesPCEndpoint(platform) + $"/{matchId}";
            internal static string MatchesXboxEndpoint(PubgRegion region) => string.Format(ShardedBaseUrl + "/matches", region.Serialize());
            internal static string MatchesXboxEndpoint(PubgRegion region, string matchId) => MatchesXboxEndpoint(region) + $"/{matchId}";
        }

        internal static class Status
        {
            internal static string StatusEndpoint() => PubgApiConfiguration.GetApiBase() + "/status";
        }

        internal static class Players
        {
            internal static string PlayersEndpoint(PubgRegion region) => string.Format(ShardedBaseUrl + "/players", region.Serialize());
            internal static string PlayersEndpoint(PubgRegion region, string playerId) => PlayersEndpoint(region) + $"/{playerId}";
            internal static string PlayerSeasonsPCEndpoint(PubgPlatform platform, string playerId, string seasonId) => string.Format(ShardedBaseUrl + "/players/{1}/seasons/{2}", platform.Serialize(), playerId, seasonId);
            internal static string PlayerSeasonsXboxEndpoint(PubgRegion region, string playerId, string seasonId) => PlayersEndpoint(region) + $"/{playerId}/seasons/{seasonId}";
        }

        internal static class Samples
        {
            internal static string SamplesEndpoint(PubgRegion region) => string.Format(ShardedBaseUrl + "/samples", region.Serialize());
        }

        internal static class Seasons
        {
            internal static string SeasonsPCEndpoint(PubgPlatform platform) => string.Format(ShardedBaseUrl + "/seasons", platform.Serialize());
            internal static string SeasonsXboxEndpoint(PubgRegion region) => string.Format(ShardedBaseUrl + "/seasons", region.Serialize());
        }

        internal static class Tournaments
        {
            internal static string TournamentsEndpoint() => PubgApiConfiguration.GetApiBase() + "/tournaments";
            internal static string TournamentsEndpoint(string tournamentId) => TournamentsEndpoint() + $"/{tournamentId}";
        }
    }
}

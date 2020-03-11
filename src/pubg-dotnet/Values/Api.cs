using Pubg.Net.Extensions;

namespace Pubg.Net.Values
{
    internal static class Api
    {
        internal const string DefaultBaseUrl = "https://api.pubg.com";
        internal static string ShardedBaseUrl = PubgApiConfiguration.GetApiBase() + "/shards/{0}";

        internal static class Leaderboard
        {
            internal static string LeaderboardEndpoint(PubgPlatform platform, PubgGameMode gameMode, string seasonId) 
                => string.Format(ShardedBaseUrl + "/leaderboards/{1}/{2}", platform.Serialize(), seasonId, gameMode.Serialize());
        }

        internal static class Matches
        {
            internal static string MatchesEndpoint(PubgPlatform platform) => string.Format(ShardedBaseUrl + "/matches", platform.Serialize());
            internal static string MatchesEndpoint(PubgPlatform platform, string matchId) => MatchesEndpoint(platform) + $"/{matchId}";
        }

        internal static class Status
        {
            internal static string StatusEndpoint() => PubgApiConfiguration.GetApiBase() + "/status";
        }

        internal static class Players
        {
            internal static string PlayersEndpoint(PubgPlatform platform) => string.Format(ShardedBaseUrl + "/players", platform.Serialize());
            internal static string PlayersEndpoint(PubgPlatform platform, string playerId) => PlayersEndpoint(platform) + $"/{playerId}";
            internal static string PlayerSeasonsEndpoint(PubgPlatform platform, string playerId, string seasonId) => string.Format(ShardedBaseUrl + "/players/{1}/seasons/{2}", platform.Serialize(), playerId, seasonId);
        }

        internal static class Samples
        {
            internal static string SamplesEndpoint(PubgPlatform platform) => string.Format(ShardedBaseUrl + "/samples", platform.Serialize());
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

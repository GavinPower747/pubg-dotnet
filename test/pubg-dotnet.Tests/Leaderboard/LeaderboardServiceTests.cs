using FluentAssertions;
using Pubg.Net;
using Pubg.Net.Services.Leaderboard;
using Pubg.Net.Tests.Util;
using System.Linq;
using Xunit;

namespace pubg.net.Tests.Leaderboard
{
    public class LeaderboardServiceTests : TestBase
    {
        [Theory]
        [InlineData(PubgGameMode.Duo)]
        [InlineData(PubgGameMode.DuoFPP)]
        [InlineData(PubgGameMode.Solo)]
        [InlineData(PubgGameMode.SoloFPP)]
        [InlineData(PubgGameMode.Squad)]
        [InlineData(PubgGameMode.SquadFPP)]
        public void Can_Get_Leaderboard(PubgGameMode gameMode)
        {
            var service = new PubgLeaderboardService(Storage.ApiKey);

            var leaderboard = service.GetGameModeLeaderboard(PubgPlatform.Steam, gameMode);

            leaderboard.Id.Should().NotBeNullOrEmpty();
            leaderboard.ShardId.Should().NotBeNullOrEmpty();
            Assert.All(leaderboard.Players, player => player.Id.Should().NotBeNullOrEmpty());
            Assert.All(leaderboard.Players, player => player.Name.Should().NotBeNullOrEmpty());
        }
    }
}

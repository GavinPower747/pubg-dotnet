using Pubg.Net.Tests.Util;
using Pubg.Net.Exceptions;
using System.Linq;
using Xunit;
using pubg.net.Tests;
using FluentAssertions;

namespace Pubg.Net.Tests.Players
{
    public class PlayerTests : TestBase
    {
        [Fact]
        public void Can_Get_Players_ByName()
        {
            var playerService = new PubgPlayerService(Storage.ApiKey);

            var playerNames = Storage.GetMatch(PubgRegion.PCEurope).Rosters.SelectMany(r => r.Participants).Select(p => p.Stats.Name).Take(5).ToArray();

            var filter = new GetPubgPlayersRequest
            {
                PlayerNames = playerNames
            };

            var players = playerService.GetPlayers(PubgRegion.PCEurope, filter);

            Assert.NotEmpty(players);
            Assert.All(players.Select(p => p.Name), name => playerNames.Contains(name));
        }

        [Fact]
        public void Can_Get_Players_ById()
        {
            var playerService = new PubgPlayerService(Storage.ApiKey);

            var playerIds = Storage.GetMatch(PubgRegion.PCEurope).Rosters.SelectMany(r => r.Participants).Select(p => p.Stats.PlayerId).Take(5).ToArray();

            var filter = new GetPubgPlayersRequest
            {
                PlayerIds = playerIds
            };

            var players = playerService.GetPlayers(PubgRegion.PCEurope, filter);

            Assert.NotEmpty(players);
            Assert.All(players.Select(p => p.Id), id => playerIds.Contains(id));
        }

        [Fact]
        public void Can_Get_Player()
        {
            var playerService = new PubgPlayerService(Storage.ApiKey);

            var playerId = Storage.GetMatch(PubgRegion.PCEurope).Rosters.SelectMany(r => r.Participants).Select(p => p.Stats.PlayerId).FirstOrDefault();

            var player = playerService.GetPlayer(PubgRegion.PCEurope, playerId);

            player.Id.Should().NotBeNull();
            player.MatchIds.Should().NotBeNullOrEmpty();
            player.Name.Should().NotBeNullOrWhiteSpace();
        }

        [Fact]
        public void Can_Get_Season_For_Player_OnPC()
        {
            var playerService = new PubgPlayerService(Storage.ApiKey);

            var region = PubgRegion.PCEurope;
            var playerId = Storage.GetMatch(region).Rosters.SelectMany(r => r.Participants).Select(p => p.Stats.PlayerId).FirstOrDefault();
            var seasonId = Storage.GetSeason(region).Id;

            var playerSeason = playerService.GetPlayerSeasonPC(playerId, seasonId);

            playerSeason.Should().NotBeNull();
            playerSeason.GameModeStats.Should().NotBeNull();
            playerSeason.SeasonId.Should().NotBeNullOrWhiteSpace();
            playerSeason.PlayerId.Should().NotBeNullOrWhiteSpace();
            playerSeason.GameModeStats.Should().NotBeNull();
            playerSeason.GameModeStats.Solo.Should().NotBeNull();
            playerSeason.GameModeStats.SoloFPP.Should().NotBeNull();
            playerSeason.GameModeStats.Duo.Should().NotBeNull();
            playerSeason.GameModeStats.DuoFPP.Should().NotBeNull();
            playerSeason.GameModeStats.Squad.Should().NotBeNull();
            playerSeason.GameModeStats.SquadFPP.Should().NotBeNull();
        }

        [Fact]
        public void Can_Get_LifetimeStats_For_Player_OnPC()
        {
            var playerService = new PubgPlayerService(Storage.ApiKey);

            var region = PubgRegion.PCEurope;
            var playerId = Storage.GetMatch(region).Rosters.SelectMany(r => r.Participants).Select(p => p.Stats.PlayerId).FirstOrDefault();

            var lifeTimeStats = playerService.GetPlayerLifetimeStats(PubgPlatform.Steam, playerId);

            lifeTimeStats.PlayerId.Should().BeEquivalentTo(playerId);
            lifeTimeStats.GameModeStats.Should().NotBeNull();
        }

        public void Can_Get_Season_For_Player_OnXbox()
        {
            var playerService = new PubgPlayerService(Storage.ApiKey);

            var region = PubgRegion.PCEurope;
            var playerId = Storage.GetMatch(region).Rosters.SelectMany(r => r.Participants).Select(p => p.Stats.PlayerId).FirstOrDefault();
            var seasonId = Storage.GetSeason(region).Id;

            var playerSeason = playerService.GetPlayerSeasonXbox(region, playerId, seasonId);

            playerSeason.Should().NotBeNull();
            playerSeason.GameModeStats.Should().NotBeNull();
            playerSeason.SeasonId.Should().NotBeNullOrWhiteSpace();
            playerSeason.PlayerId.Should().NotBeNullOrWhiteSpace();
            playerSeason.GameModeStats.Should().NotBeNull();
            playerSeason.GameModeStats.Solo.Should().NotBeNull();
            playerSeason.GameModeStats.SoloFPP.Should().NotBeNull();
            playerSeason.GameModeStats.Duo.Should().NotBeNull();
            playerSeason.GameModeStats.DuoFPP.Should().NotBeNull();
            playerSeason.GameModeStats.Squad.Should().NotBeNull();
            playerSeason.GameModeStats.SquadFPP.Should().NotBeNull();
        }

        [Fact]
        public void GetPlayers_Throws_Exception_When_NotFound()
        {
            var playerService = new PubgPlayerService(Storage.ApiKey);

            var filter = new GetPubgPlayersRequest
            {
                PlayerNames = new string[] { "NonExistantPlayerHopefully" }
            };

            Assert.Throws<PubgNotFoundException>(() => playerService.GetPlayers(PubgRegion.PCEurope, filter));
        }
    }
}

using Pubg.Net.Tests.Util;
using Pubg.Net.Exceptions;
using System.Linq;
using Xunit;
using pubg.net.Tests;

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

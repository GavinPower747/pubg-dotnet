using pubg.net.Tests.Util;
using Pubg.Net;
using Pubg.Net.Exceptions;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace pubg.net.Tests.Players
{
    public class PlayerTests
    {
        [Fact]
        public void Can_Get_Players_ByName_Sync()
        {
            var playerService = new PubgPlayerService(Values.ApiKey);

            KnownPlayers.KnownPlayerNames.TryGetValue(PubgRegion.PCEurope, out string[] playerNames);

            var filter = new GetPubgPlayersRequest
            {
                PlayerNames = playerNames
            };

            var players = playerService.GetPlayers(PubgRegion.PCEurope, filter);

            Assert.NotEmpty(players);
            Assert.All(players.Select(p => p.Name), name => playerNames.Contains(name));
        }

        [Fact]
        public async Task Can_Get_Players_ByName_Async()
        {
            var playerService = new PubgPlayerService(Values.ApiKey);

            KnownPlayers.KnownPlayerNames.TryGetValue(PubgRegion.PCEurope, out string[] playerNames);

            var filter = new GetPubgPlayersRequest
            {
                PlayerNames = playerNames
            };

            var players = await playerService.GetPlayersAsync(PubgRegion.PCEurope, filter);

            Assert.NotEmpty(players);
            Assert.All(players.Select(p => p.Name), name => playerNames.Contains(name));
        }

        [Fact]
        public void Can_Get_Players_ById_Sync()
        {
            var playerService = new PubgPlayerService(Values.ApiKey);

            KnownPlayers.KnownPlayerIds.TryGetValue(PubgRegion.PCEurope, out string[] playerIds);

            var filter = new GetPubgPlayersRequest
            {
                PlayerIds = playerIds
            };

            var players = playerService.GetPlayers(PubgRegion.PCEurope, filter);

            Assert.NotEmpty(players);
            Assert.All(players.Select(p => p.Id), id => playerIds.Contains(id));
        }

        [Fact]
        public async Task Can_Get_Players_ById_Async()
        {
            var playerService = new PubgPlayerService(Values.ApiKey);

            KnownPlayers.KnownPlayerIds.TryGetValue(PubgRegion.PCEurope, out string[] playerIds);

            var filter = new GetPubgPlayersRequest
            {
                PlayerIds = playerIds
            };

            var players = await playerService.GetPlayersAsync(PubgRegion.PCEurope, filter);

            Assert.NotEmpty(players);
            Assert.All(players.Select(p => p.Id), id => playerIds.Contains(id));
        }

        [Fact]
        public void GetPlayers_Throws_Exception_When_NotFound()
        {
            var playerService = new PubgPlayerService(Values.ApiKey);

            var filter = new GetPubgPlayersRequest
            {
                PlayerNames = new string[] { "NonExistantPlayerHopefully" }
            };

            Assert.Throws<PubgNotFoundException>(() => playerService.GetPlayers(PubgRegion.PCEurope, filter));
        }

        [Fact]
        public void GetPlayer_Throws_Exception_When_NotFound()
        {
            var playerService = new PubgPlayerService(Values.ApiKey);

            Assert.Throws<PubgNotFoundException>(() => playerService.GetPlayer(PubgRegion.PCEurope, "account.00000000000000000000"));
        }

    }
}

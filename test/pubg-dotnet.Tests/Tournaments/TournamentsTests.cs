using FluentAssertions;
using Pubg.Net;
using Pubg.Net.Tests.Util;
using System.Linq;
using Xunit;

namespace pubg.net.Tests.Tournaments
{
    public class TournamentsTests : TestBase
    {
        [Fact]
        public void Can_Get_Tournaments()
        {
            var tournamentService = new PubgTournamentService(Storage.ApiKey);

            var tournaments = tournamentService.GetTournaments();

            Assert.All(tournaments, t => t.Id.Should().NotBeNullOrWhiteSpace());
            Assert.All(tournaments, t => t.Type.Should().NotBeNullOrWhiteSpace());
        }

        [Fact]
        public void Can_Get_Tournament_From_List()
        {
            var tournamentService = new PubgTournamentService(Storage.ApiKey);

            var tournaments = tournamentService.GetTournaments();
            var tournamentToGet = tournaments.FirstOrDefault();

            tournamentToGet.Should().NotBeNull();

            var retrievedTournament = tournamentService.GetTournament(tournamentToGet.Id);

            retrievedTournament.Should().NotBeNull();
            retrievedTournament.Id.Should().NotBeNullOrWhiteSpace();
            retrievedTournament.Type.Should().NotBeNullOrWhiteSpace();
            retrievedTournament.MatchIds.Should().NotBeEmpty();
        }
    }
}

using FluentAssertions;
using Pubg.Net;
using Pubg.Net.Tests.Util;
using Xunit;

namespace pubg.net.Tests.Seasons
{
    public class SeasonsTests
    {
        [Fact]
        public void Can_Get_Seasons()
        {
            var seasonsService = new PubgSeasonService(Storage.ApiKey);

            var seasons = seasonsService.GetSeasons(PubgRegion.PCEurope);

            Assert.All(seasons, s => s.Id.Should().NotBeNull());
            seasons.Should().ContainSingle(s => s.IsCurrentSeason == true);
        }
    }
}

using FluentAssertions;
using Pubg.Net;
using Pubg.Net.Tests.Util;
using Xunit;

namespace pubg.net.Tests.Seasons
{
    public class SeasonsTests
    {
        [Theory]
        [InlineData(PubgPlatform.Steam)]
        [InlineData(PubgPlatform.Xbox)]
        [InlineData(PubgPlatform.PlayStation)]
        public void Can_Get_Seasons(PubgPlatform platform)
        {
            var seasonsService = new PubgSeasonService(Storage.ApiKey);

            var seasons = seasonsService.GetSeasons(platform);

            Assert.All(seasons, s => s.Id.Should().NotBeNull());
            seasons.Should().ContainSingle(s => s.IsCurrentSeason == true);
        }
    }
}

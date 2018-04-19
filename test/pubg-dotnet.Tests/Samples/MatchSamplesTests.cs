using FluentAssertions;
using Pubg.Net;
using Pubg.Net.Extensions;
using Pubg.Net.Tests.Util;
using System;
using Xunit;

namespace pubg.net.Tests.Samples
{
    public class MatchSamplesTests : TestBase
    {
        [Fact]
        public void Can_Get_MatchSamples_When_NoFilterGiven()
        {
            var region = PubgRegion.PCEurope;
            var samplesService = new PubgSamplesService(Storage.ApiKey);

            var matchSamples = samplesService.GetMatchSamples(region);

            matchSamples.Should().NotBeNull();
            matchSamples.MatchIds.Should().NotBeNullOrEmpty();
            matchSamples.ShardId.Should().BeEquivalentTo(region.Serialize());
        }

        [Fact]
        public void Can_Get_MatchSamples_When_FilterGiven()
        {
            var region = PubgRegion.PCEurope;
            var samplesService = new PubgSamplesService(Storage.ApiKey);
            var createdDate = DateTime.UtcNow.AddDays(-1);

            var matchSamples = samplesService.GetMatchSamples(region, new GetSamplesRequest { CreatedAtStart = createdDate });

            matchSamples.Should().NotBeNull();
            matchSamples.MatchIds.Should().NotBeNullOrEmpty();
            matchSamples.ShardId.Should().BeEquivalentTo(region.Serialize());
        }
    }
}

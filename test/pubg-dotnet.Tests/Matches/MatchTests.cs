using FluentAssertions;
using Pubg.Net.Tests.Util;
using Pubg.Net.Extensions;
using System.Linq;
using Xunit;
using Pubg.Net.Exceptions;
using System;

namespace Pubg.Net.Tests.Matches
{
    public class MatchTests
    {
        [Fact]
        public void Can_Retrieve_Match()
        {
            var region = PubgRegion.PCEurope;
            var player = Storage.GetPlayer(region);
            var matchService = new PubgMatchService(Storage.ApiKey);

            var match = matchService.GetMatch(region, player.MatchIds.FirstOrDefault());

            match.ShardId.Should().Equals(region.Serialize());
            match.Rosters.Should().NotBeNull();

            Assert.All(match.Rosters, r => r.Stats.Rank.Should().BeGreaterThan(0));
            match.Rosters.Should().ContainSingle(x => x.Won == true);

            var participants = match.Rosters.SelectMany(x => x.Participants);

            participants.Should().NotBeNullOrEmpty();

            var matchPlayer = participants.FirstOrDefault(p => p.Stats.PlayerId == player.Id);

            matchPlayer.Should().NotBeNull();
            matchPlayer.Stats.Name.Should().Equals(player.Name);
            
            Assert.All(participants, p => p.Stats.Should().NotBeNull());
            Assert.All(participants, p => p.Stats.KillPlace.Should().BeGreaterThan(0));
            Assert.All(participants, p => p.Stats.WinPlace.Should().BeGreaterThan(0));
            Assert.All(participants, p => p.ShardId.Should().Equals(region.Serialize()));
            Assert.All(participants, p => p.Id.Should().NotBeNullOrWhiteSpace());
        }

        [Fact]
        public void Throws_Exception_When_NotFound()
        {
            Assert.Throws<PubgNotFoundException>(() => new PubgMatchService(Storage.ApiKey).GetMatch(PubgRegion.PCEurope, Guid.Empty.ToString()));
        }
    }
}

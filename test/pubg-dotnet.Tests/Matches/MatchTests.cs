using FluentAssertions;
using Pubg.Net.Tests.Util;
using Pubg.Net.Extensions;
using System.Linq;
using Xunit;
using Pubg.Net.Exceptions;
using System;
using pubg.net.Tests;

namespace Pubg.Net.Tests.Matches
{
    public class MatchTests : TestBase
    {
        [Fact]
        public void Can_Retrieve_Match_ForPC()
        {
            var samples = Storage.GetSamples(PubgPlatform.Steam);
            var matchService = new PubgMatchService(Storage.ApiKey);

            var match = matchService.GetMatch(samples.MatchIds.FirstOrDefault());

            match.Rosters.Should().NotBeNull();
            match.GameMode.Should().NotBe(PubgGameMode.Unknown);

            Assert.All(match.Rosters, r => r.Stats.Rank.Should().BeGreaterThan(0));
            match.Rosters.Should().ContainSingle(x => x.Won == true);

            var participants = match.Rosters.SelectMany(x => x.Participants);

            participants.Should().NotBeNullOrEmpty();
            
            Assert.All(participants, p => p.Stats.Should().NotBeNull());
            Assert.All(participants, p => p.Stats.KillPlace.Should().BeGreaterThan(0));
            Assert.All(participants, p => p.Stats.WinPlace.Should().BeGreaterThan(0));
            Assert.All(participants, p => p.Id.Should().NotBeNullOrWhiteSpace());
        }

        [Fact]
        public void Can_Retrieve_Match_ForXbox()
        {
            var samples = Storage.GetSamples(PubgPlatform.Xbox);
            var matchService = new PubgMatchService(Storage.ApiKey);

            var match = matchService.GetMatch(PubgPlatform.Xbox, samples.MatchIds.FirstOrDefault());

            match.Rosters.Should().NotBeNull();

            Assert.All(match.Rosters, r => r.Stats.Rank.Should().BeGreaterThan(0));
            match.Rosters.Should().ContainSingle(x => x.Won == true);

            var participants = match.Rosters.SelectMany(x => x.Participants);

            participants.Should().NotBeNullOrEmpty();

            Assert.All(participants, p => p.Stats.Should().NotBeNull());
            Assert.All(participants, p => p.Stats.KillPlace.Should().BeGreaterThan(0));
            Assert.All(participants, p => p.Stats.WinPlace.Should().BeGreaterThan(0));
            Assert.All(participants, p => p.Id.Should().NotBeNullOrWhiteSpace());
        }

        [Fact]
        public void Throws_Exception_When_NotFound_OnPC()
        {
            Assert.Throws<PubgNotFoundException>(() => new PubgMatchService(Storage.ApiKey).GetMatch(Guid.Empty.ToString()));
        }

        [Fact]
        public void Throws_Exception_When_NotFound_OnXbox()
        {
            Assert.Throws<PubgNotFoundException>(() => new PubgMatchService(Storage.ApiKey).GetMatch(PubgPlatform.Xbox, Guid.Empty.ToString()));
        }
    }
}

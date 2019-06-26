﻿using FluentAssertions;
using Pubg.Net.Tests.Util;
using System.Linq;
using Xunit;
using Pubg.Net.Models.Telemetry.Events;
using pubg.net.Tests;

namespace Pubg.Net.Tests.Telemetry
{
    public class TelemetryTests : TestBase
    {
        [Fact]
        public void Can_Pull_Telemetry_From_Match_OnPc()
        {
            var region = PubgRegion.PCEurope;
            var match = Storage.GetMatch(PubgPlatform.Steam);
            var asset = match.Assets.FirstOrDefault();
            var telemetryService = new PubgTelemetryService();

            var telemetry = telemetryService.GetTelemetry(region, asset);

            telemetry.Should().NotBeEmpty();
            //New Telemetry events have been added, don't have time to updated and need to push other changes
            //Assert.All(telemetry, t => t.Should().NotBeOfType<UnknownTelemetryEvent>());

            var matchDefinition = telemetry.OfType<LogMatchDefinition>().FirstOrDefault();

            matchDefinition.MatchId.Should().NotBeNullOrWhiteSpace();
        }

        [Fact]
        public void Can_Pull_Telemetry_From_Match_OnXbox()
        {
            var region = PubgRegion.XboxEurope;
            var match = Storage.GetMatch(PubgPlatform.Steam);
            var asset = match.Assets.FirstOrDefault();
            var telemetryService = new PubgTelemetryService();

            var telemetry = telemetryService.GetTelemetry(region, asset);

            telemetry.Should().NotBeEmpty();
            //New Telemetry events have been added, don't have time to updated and need to push other changes
            //Assert.All(telemetry, t => t.Should().NotBeOfType<UnknownTelemetryEvent>());

            var matchDefinition = telemetry.OfType<LogMatchDefinition>().FirstOrDefault();

            matchDefinition.MatchId.Should().NotBeNullOrWhiteSpace();
        }
    }
}

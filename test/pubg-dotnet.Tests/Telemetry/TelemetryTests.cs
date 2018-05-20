using FluentAssertions;
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
            var match = Storage.GetMatch(region);
            var asset = match.Assets.FirstOrDefault();
            var telemetryService = new PubgTelemetryService();

            var telemetry = telemetryService.GetTelemetry(region, asset);

            telemetry.Should().NotBeEmpty();
            Assert.All(telemetry, t => t.Should().NotBeOfType<UnknownTelemetryEvent>());
        }

        [Fact]
        public void Can_Pull_Telemetry_From_Match_OnXbox()
        {
            var region = PubgRegion.XboxEurope;
            var match = Storage.GetMatch(region);
            var asset = match.Assets.FirstOrDefault();
            var telemetryService = new PubgTelemetryService();

            var telemetry = telemetryService.GetTelemetry(region, asset);

            telemetry.Should().NotBeEmpty();
            Assert.All(telemetry, t => t.Should().NotBeOfType<UnknownTelemetryEvent>());
        }
    }
}

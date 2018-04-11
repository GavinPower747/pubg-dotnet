using FluentAssertions;
using Pubg.Net.Tests.Util;
using Pubg.Net;
using System.Linq;
using Xunit;

namespace Pubg.Net.Tests.Telemetry
{
    public class TelemetryTests
    {
        [Fact]
        public void Can_Pull_Telemetry_From_Match()
        {
            var match = Storage.GetMatch(PubgRegion.PCEurope);
            var asset = match.Assets.FirstOrDefault();
            var telemetryService = new PubgTelemetryService();

            var telemetry = telemetryService.GetTelemetry(PubgRegion.PCEurope, asset);

            telemetry.Should().NotBeEmpty();
        }
    }
}

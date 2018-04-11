using FluentAssertions;
using Pubg.Net.Tests.Util;
using Pubg.Net;
using Xunit;

namespace Pubg.Net.Tests.Status
{
    public class StatusTests
    {
        [Fact]
        public void Can_Retrieve_Status()
        {
            var status = new PubgStatusService(Storage.ApiKey).GetStatus();

            status.Attributes.Should().NotBeNull();
            status.Attributes.Version.Should().NotBeNullOrWhiteSpace();
            status.Id.Should().NotBeNullOrWhiteSpace();
        }
    }
}

using FluentAssertions;
using Pubg.Net.Tests.Util;
using Pubg.Net;
using Xunit;
using pubg.net.Tests;

namespace Pubg.Net.Tests.Status
{
    public class StatusTests : TestBase
    {
        [Fact]
        public void Can_Retrieve_Status()
        {
            var status = new PubgStatusService(Storage.ApiKey).GetStatus();
            status.Id.Should().NotBeNullOrWhiteSpace();
        }
    }
}

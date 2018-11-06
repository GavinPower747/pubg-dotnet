using Pubg.Net;
using Pubg.Net.Extensions;

namespace pubg.net.Tests.Extensions
{
    public static class PubgRegionExtensions
    {
        public static bool IsPC(this PubgRegion region) => region.Serialize().ToLowerInvariant().Contains("pc");
        public static bool IsXbox(this PubgRegion region) => region.Serialize().ToLowerInvariant().Contains("xbox");
    }
}

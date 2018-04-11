using Pubg.Net;
using System.Collections.Generic;

namespace pubg.net.Tests.Util
{
    //Far from ideal but the only way I can think of
    public static class KnownPlayers
    {
        public static Dictionary<PubgRegion, string[]> KnownPlayerNames = new Dictionary<PubgRegion, string[]>
        {
            {
                PubgRegion.PCEurope,
                new string[] 
                {
                    "jebuzjack",
                    "dutsization",
                    "irishdiablo",
                    "chmcl08"
                }
            }
        };

        public static Dictionary<PubgRegion, string[]> KnownPlayerIds = new Dictionary<PubgRegion, string[]>
        {
            {
                PubgRegion.PCEurope,
                new string[]
                {
                    "account.dbe0812874d642f7be09814cfb92c89a"
                }
            }
        };
    }
}

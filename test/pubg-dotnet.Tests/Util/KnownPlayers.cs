using Pubg.Net;
using System.Collections.Generic;

namespace Pubg.Net.Tests.Util
{
    //Far from ideal but there is no way to query a list of players
    public static class KnownPlayers
    {
        public static Dictionary<PubgRegion, string[]> KnownPlayerNames = new Dictionary<PubgRegion, string[]>
        {
            {
                PubgRegion.PCEurope,
                new string[] 
                {
                    "jebuzjack",
                    "Dutsization",
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
                    "account.dbe0812874d642f7be09814cfb92c89a",
                    "account.e9548dfdc07847b29bb51cbcc0b4cde7"
                }
            }
        };
    }
}

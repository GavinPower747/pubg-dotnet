using System;
using System.Collections.Generic;

namespace pubg.net.Tests
{
    public static class Values
    {
        public static string ApiKey => Environment.GetEnvironmentVariable("PUBG_API_KEY");
        public static Dictionary<string, object> Items { get; set; }
    }
}

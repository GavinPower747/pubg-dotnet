using System;

namespace Pubg.Net.Configuration
{
    public class PubgApiSettings
    {
        public string ApiKey { get; set; }
        public string ApiBaseUrl { get; set; }
        public TimeSpan? HttpTimeout { get; set; }
    }
}

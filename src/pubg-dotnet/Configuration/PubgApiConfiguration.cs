using Pubg.Net.Values;
using System;

namespace Pubg.Net
{
    public static class PubgApiConfiguration
    {
        private static string _apiKey;
        private static string _apiBaseUrl;
        private static TimeSpan? _httpTimeout;

        internal static string GetApiKey() => _apiKey;
        public static void SetApiKey(string key) =>_apiKey = key;

        internal static string GetApiBase()
        {
            if(string.IsNullOrEmpty(_apiBaseUrl))
            {
                _apiBaseUrl = Api.DefaultBaseUrl;
            }

            return _apiBaseUrl;
        }

        public static void SetApiBase(string apiBase) => _apiBaseUrl = apiBase;

        internal static TimeSpan? GetHttpTimeout() => _httpTimeout;
        public static void SetHttpTimeout(TimeSpan timeout) => _httpTimeout = timeout;
    }
}

using System;
using System.Net;

namespace Pubg.Net.Exceptions
{
    public class PubgTooManyRequestsException : PubgException
    {
        public const string DefaultErrorMessage = "You have surpassed your Rate Limit";
        public string TimeUntilReset { get; set; }

        public PubgTooManyRequestsException(string timeUntilReset) : base (DefaultErrorMessage, (HttpStatusCode) 429)
        {
            TimeUntilReset = timeUntilReset;
        }
        
        public PubgTooManyRequestsException(string errorMessage, Exception innerException) : base(errorMessage, innerException)
        {
        }
    }
}

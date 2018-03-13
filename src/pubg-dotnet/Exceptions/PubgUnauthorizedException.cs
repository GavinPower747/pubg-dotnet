using System;

namespace Pubg.Net.Exceptions
{
    public class PubgUnauthorizedException : PubgException
    {
        private const string DefaultErrorMessage = "Api Key is invalid or missing!";

        public PubgUnauthorizedException() : base(DefaultErrorMessage) { }
        public PubgUnauthorizedException(string errorMessage) : base(errorMessage) { }
        public PubgUnauthorizedException(string errorMessage, Exception innerException) : base(errorMessage, innerException) { }
    }
}

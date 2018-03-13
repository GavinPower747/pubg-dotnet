using System;

namespace Pubg.Net.Exceptions
{
    public class PubgContentTypeException : PubgException
    {
        private const string DefaultErrorMessage = "Content type is unsupported or not specified";

        public PubgContentTypeException() : base(DefaultErrorMessage) { }
        public PubgContentTypeException(string errorMessage) : base(errorMessage) { }
        public PubgContentTypeException(string errorMessage, Exception innerException) : base(errorMessage, innerException) { }
    }
}

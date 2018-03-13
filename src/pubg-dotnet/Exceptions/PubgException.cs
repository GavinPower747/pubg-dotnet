using System;
using System.Net;

namespace Pubg.Net.Exceptions
{
    public class PubgException : Exception
    {
        public HttpStatusCode HttpStatusCode { get; set; }

        public PubgException(string errorMessage) : base(errorMessage) { }
        public PubgException(string errorMessage, Exception innerException) : base(errorMessage, innerException) { }
    }
}

using Pubg.Net.Models.Errors;
using System;
using System.Collections.Generic;
using System.Net;

namespace Pubg.Net.Exceptions
{
    public class PubgException : Exception
    {
        public HttpStatusCode HttpStatusCode { get; set; }
        public IEnumerable<PubgError> Errors { get; set; }

        public PubgException(string errorMessage) : base(errorMessage) { }
        public PubgException(string errorMessage, Exception innerException) : base(errorMessage, innerException) { }
        public PubgException(string errorMessage, HttpStatusCode statusCode) : base(errorMessage) { }
        public PubgException(string errorMessage, HttpStatusCode statusCode, IEnumerable<PubgError> apiErrors) : base(errorMessage)
        {
            HttpStatusCode = statusCode;
            Errors = apiErrors;
        }
    }
}

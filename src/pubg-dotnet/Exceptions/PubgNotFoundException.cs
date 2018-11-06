using System.Net;

namespace Pubg.Net.Exceptions
{
    public class PubgNotFoundException : PubgException
    {
        private const string DefaultErrorMessage = "API returned 404. An entity with the specified ID was not found";

        public PubgNotFoundException() : base(DefaultErrorMessage, HttpStatusCode.NotFound) { }
    }
}

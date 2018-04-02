using System.Net;

namespace Pubg.Net.Exceptions
{
    public class PubgNotFoundException : PubgException
    {
        private const string DefaultErrorMessage = "Unable to find specified resource";

        public PubgNotFoundException() : base(DefaultErrorMessage, HttpStatusCode.NotFound) { }
    }
}

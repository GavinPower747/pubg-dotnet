namespace Pubg.Net.Services
{
    public abstract class PubgRequest
    {
        /// <summary>
        ///     Use for setting the ApiKey per request, not needed if you've set it elsewhere
        /// </summary>
        public string ApiKey { get; set; }
    }
}

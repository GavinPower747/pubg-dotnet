namespace Pubg.Net
{ 
    public abstract class PubgService
    {
        public string ApiKey { get; set; }

        protected const string ResponseRootNode = "data";

        protected PubgService(string apiKey)
        {
            ApiKey = apiKey;
        }
    }
}

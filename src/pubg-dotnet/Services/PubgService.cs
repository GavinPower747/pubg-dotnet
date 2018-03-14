namespace Pubg.Net.Services
{
    public abstract class PubgService
    {
        public string ApiKey { get; set; }

        protected const string ResponseRootNode = "data";

        protected PubgService(string apiKey)
        {
            if (string.IsNullOrEmpty(apiKey))
                apiKey = PubgApiConfiguration.GetApiKey();

            ApiKey = apiKey;
        }
    }
}

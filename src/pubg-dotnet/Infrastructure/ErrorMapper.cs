using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Pubg.Net.Models.Errors;
using System.Collections.Generic;
using System.Linq;

namespace Pubg.Net.Infrastructure
{
    public static class ErrorMapper
    {
        public static List<PubgError> MapErrors(string json)
        {
            var jObject = JObject.Parse(json);
            var collection = jObject.SelectToken("errors");

            return collection.Select(objJson => MapError(objJson.ToString())).ToList();
        }

        private static PubgError MapError(string json)
        {
            var objectJson = JObject.Parse(json).ToString();

            var serializedObject = JsonConvert.DeserializeObject<PubgError>(objectJson);

            return serializedObject;
        }
    }
}

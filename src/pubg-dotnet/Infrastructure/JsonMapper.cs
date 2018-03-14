using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.Linq;

namespace Pubg.Net.Infrastructure
{
    public static class JsonMapper<T>
    {
        public static List<T> MapCollection(string json, string rootNode)
        {
            var jObject = JObject.Parse(json);
            var collection = jObject.SelectToken(rootNode);

            return collection.Select(objJson => MapObject(objJson.ToString(), string.Empty)).ToList();
        }

        public static T MapObject(string json, string rootNode)
        {
            var objectJson = JObject.Parse(json).SelectToken(rootNode).ToString();

            var serializedObject = JsonConvert.DeserializeObject<T>(objectJson);

            return serializedObject;
        }
    }
}

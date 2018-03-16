using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Pubg.Net.Infrastructure.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Pubg.Net.Infrastructure
{
    public static class JsonMapper<T>
    {
        public static List<T> MapCollection(string json, string rootNode)
        {
            var jObject = JObject.Parse(json);
            var collection = jObject.SelectToken(rootNode);
            var includedJson = jObject.SelectToken("included");

            return collection.Select(objJson => MapObject(objJson.ToString(), string.Empty, includedJson.ToString())).ToList();
        }

        public static T MapObject(string json, string rootNode, string includedJson = null)
        {
            var jObject = JObject.Parse(json);
            var objectJson = jObject.SelectToken(rootNode).ToString();
            includedJson = string.IsNullOrEmpty(includedJson) ? jObject.SelectToken("included").ToString() : includedJson;

            var mappedObject = MapRelatedEntities(typeof(T), objectJson, includedJson);

            var serializedObject = JsonConvert.DeserializeObject<T>(mappedObject.ToString());

            return serializedObject;
        }

        private static JObject MapRelatedEntities(Type baseType, string objectJson, string includedJson)
        {
            var baseJObject = JObject.Parse(objectJson);
            var relationshipsToken = baseJObject.SelectToken("relationships");
            var includedJArray = JArray.Parse(includedJson);

            foreach(var prop in baseType.GetRuntimeProperties())
            {
                var relatedEntity = prop.GetCustomAttribute<RelatedEnitityAttribute>();

                if (relatedEntity is null) continue;

                var relatedIds = (JArray) relationshipsToken.SelectToken($"{relatedEntity.EntityName}.data");
                var relatedEntities = includedJArray.Where(inc => relatedIds.Values<string>("id").Contains(inc["id"].ToString()));
                var relatedJArray = new JArray(relatedEntities);

                baseJObject.Add(relatedEntity.EntityName, relatedJArray);

                baseJObject = MapRelatedEntities(prop.GetType(), baseJObject.ToString(), includedJson);
            }

            return baseJObject;
        }
    }
}

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Linq;

namespace Pubg.Net.Infrastructure.JsonConverters
{
    public class RelationshipIdConverter : JsonConverter
    {
        public override bool CanConvert(Type objectType) => false;
        public override bool CanWrite => false;

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            //if the reader is not reading a relationship object just deserialize as normal.
            //This allows us to serialize and deserialize multiple times after converting from the Json-API format
            if (reader.TokenType != JsonToken.StartObject)
                return serializer.Deserialize(reader, objectType);

            JToken jt = JToken.Load(reader);

            var dataToken = jt.SelectToken("data");
            
            if (objectType == typeof(string))
                return dataToken["id"].ToString();
            
            return dataToken.Select(x => (string)x["id"]).ToList();
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) { }
    }
}

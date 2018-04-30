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
            JObject jo = JObject.Load(reader);
            var dataToken = jo.SelectToken("data");

            if (objectType == typeof(string))
                return dataToken["id"].ToString();

            return dataToken.Select(x => (string)x["id"]).ToList();
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) { }
    }
}

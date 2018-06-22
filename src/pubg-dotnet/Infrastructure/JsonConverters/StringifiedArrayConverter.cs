using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Pubg.Net.Infrastructure.JsonConverters
{
    //Don't ask because I don't know - Gav
    public class StringifiedArrayConverter<T> : JsonConverter
    {
        public override bool CanConvert(Type objectType) => false;
        public override bool CanWrite => false;

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            JToken token = JToken.Load(reader);
            return JsonConvert.DeserializeObject<IEnumerable<T>>(token.ToString());
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) => throw new NotSupportedException();
    }
}

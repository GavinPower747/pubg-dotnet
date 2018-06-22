using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Pubg.Net.Infrastructure.JsonConverters
{
    //Don't ask because I don't know - Gav
    public class StringifiedArrayConverter<T> : JsonConverter
    {
        public override bool CanConvert(Type objectType) => false;
        public override bool CanWrite => false;

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            string item = serializer.Deserialize<string>(reader);
            return JsonConvert.DeserializeObject<IEnumerable<T>>(item);
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) => throw new NotSupportedException();
    }
}

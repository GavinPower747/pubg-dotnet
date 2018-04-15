using System;
using System.Linq;
using System.Reflection;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Pubg.Net;
using Pubg.Net.Models.Telemetry.Events;

namespace Pubg.Net.Infrastructure.JsonConverters
{
    public class PubgTelemetryConverter : PropertyBasedConverter<PubgTelemetryEvent>
    {
        protected override PubgTelemetryEvent Create(Type objectType, JObject jObject)
        {
            var jsonProp = objectType.GetProperty(nameof(PubgTelemetryEvent.Type)).GetCustomAttribute<JsonPropertyAttribute>().PropertyName;
            var typeName = (string)jObject.Property(jsonProp);

            if (typeName != null)
            {
                var baseType = typeof(PubgTelemetryEvent);
                var eventTypes = baseType.Assembly.GetTypes().Where(t => t.IsSubclassOf(baseType));

                foreach (var eventType in eventTypes)
                {
                    if (typeName.ToLowerInvariant().Equals(eventType.Name.ToLowerInvariant()))
                        return (PubgTelemetryEvent)Activator.CreateInstance(eventType);
                }
            }

            return new UnknownTelemetryEvent(jObject);
        }
    }
}

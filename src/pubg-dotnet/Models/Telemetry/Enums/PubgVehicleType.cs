using Newtonsoft.Json;
using Pubg.Net.Infrastructure.Attributes;
using Pubg.Net.Infrastructure.JsonConverters;
using System.Runtime.Serialization;

namespace Pubg.Net.Models.Telemetry.Enums
{
    [JsonConverter(typeof(DefaultValueStringEnumConverter))]
    public enum PubgVehicleType
    {
        [DefaultEnumMember]
        None,
        [EnumMember( Value ="FloatingVehicle")]
        FloatingVehicle,
        [EnumMember( Value ="Parachute")]
        Parachute,
        [EnumMember( Value ="TransportAircraft")]
        TransportAircraft,
        [EnumMember( Value ="WheeledVehicle")]
        WheeledVehicle
    }
}

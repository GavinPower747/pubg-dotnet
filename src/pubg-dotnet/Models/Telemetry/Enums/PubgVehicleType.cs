using System.Runtime.Serialization;

namespace Pubg.Net.Models.Telemetry.Enums
{
    public enum PubgVehicleType
    {
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

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace Pubg.Net.Models.Participants
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PubgParticipantDeathType
    {
        [EnumMember(Value = "alive")]
        Alive,
        [EnumMember(Value = "byplayer")]
        ByPlayer,
        [EnumMember(Value = "suicide")]
        Suicide,
        [EnumMember(Value = "logout")]
        Logout,
        [EnumMember(Value = "byzone")]
        ByZone
    }
}

using Newtonsoft.Json;
using System;

namespace Pubg.Net.Extensions
{
    public static class EnumExtensions
    {
        public static string Serialize(this Enum e)
        {
            return JsonConvert.SerializeObject(e).Trim('"');
        }
    }
}

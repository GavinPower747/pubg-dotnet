using System;
using Newtonsoft.Json;
using Pubg.Net.Services;

namespace Pubg.Net
{
    public class GetPubgMatchRequest : PubgRequest
    {
        /// <summary>
        ///     The amount you would like to offset the page by (0 for page 1, 1 for page 2 etc.)
        /// </summary>
        [JsonProperty("page[offset]")]
        public int? PageOffset { get; set; }

        /// <summary>
        ///     The amount of results per page (Maximum of 5)
        /// </summary>
        [JsonProperty("page[limit]")]
        public int? PageSize { get; set; }

        /// <summary>
        ///     Start of the date filter (Default: UTC Now)
        /// </summary>
        [JsonProperty("filter[createdAt-start]")]
        public DateTime? FilterStart { get; set; }

        /// <summary>
        ///     End of the date filter (Default: UTC Now - 14 days)
        /// </summary>
        [JsonProperty("filter[createdAt-end]")]
        public DateTime? FilterEnd { get; set; }

        /// <summary>
        ///     Filter By PlayerIds
        /// </summary>
        [JsonProperty("filter[playerIds]")]
        public string[] PlayerIds { get; set; }

        /// <summary>
        ///     Filter matches by game mode
        /// </summary>
        [JsonProperty("filter[gameMode]")]
        public PubgGameMode GameMode { get; set; }
    }
}

using System;

namespace Pubg.Net
{
    public class GetPubgMatchRequest
    {
        /// <summary>
        ///     The amount you would like to offset the page by (0 for page 1, 1 for page 2 etc.)
        /// </summary>
        public int? PageOffset { get; set; }

        /// <summary>
        ///     The amount of results per page (Maximum of 5)
        /// </summary>
        public int? PageSize { get; set; }
        
        /// <summary>
        ///     Start of the date filter (Default: UTC Now)
        /// </summary>
        public DateTime? FilterStart { get; set; }

        /// <summary>
        ///     End of the date filter (Default: UTC Now - 14 days)
        /// </summary>
        public DateTime? FilterEnd { get; set; }

        /// <summary>
        ///     Filter By PlayerIds
        /// </summary>
        public string[] PlayerIds { get; set; }

        /// <summary>
        ///     Filter matches by game mode
        /// </summary>
        public PubgGameMode GameMode { get; set; }
    }
}

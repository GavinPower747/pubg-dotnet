using Pubg.Net;
using Pubg.Net.Extensions;
using Pubg.Net.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Pubg.Net.Tests.Util
{
    public static class Storage
    {
        static Storage()
        {
            StoredItems = new List<PubgEntity>();
        }

        public static string ApiKey => Environment.GetEnvironmentVariable("PUBG_API_KEY");
        public static List<PubgEntity> StoredItems { get; set; }

        public static PubgPlayer GetPlayer(PubgRegion region)
        {
            var player = StoredItems.OfType<PubgPlayer>().FirstOrDefault(p => p.ShardId == region.Serialize());

            if (player != null)
                return player;

            var playerService = new PubgPlayerService(ApiKey);
            var knownPlayerNames = KnownPlayers.KnownPlayerNames.FirstOrDefault(p => p.Key == region);
            var players = playerService.GetPlayers(knownPlayerNames.Key, new GetPubgPlayersRequest { PlayerNames = knownPlayerNames.Value });

            StoredItems.AddRange(players);

            return players.FirstOrDefault();
        }

        public static PubgMatch GetMatch(PubgRegion region)
        {
            var match = StoredItems.OfType<PubgMatch>().FirstOrDefault(p => p.ShardId == region.Serialize());

            if (match != null)
                return match;

            var player = GetPlayer(region);
            match = new PubgMatchService(ApiKey).GetMatch(region, player.MatchIds.First());

            StoredItems.Add(match);

            return match;
        }
    }
}

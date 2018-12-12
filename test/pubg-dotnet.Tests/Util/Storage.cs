using pubg.net.Tests.Extensions;
using Pubg.Net;
using Pubg.Net.Extensions;
using Pubg.Net.Models.Base;
using Pubg.Net.Models.Samples;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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

        public static PubgMatchSample GetSamples(PubgRegion region)
        {
            var samples = StoredItems.OfType<PubgMatchSample>().FirstOrDefault(p => p.ShardId == region.Serialize());

            if (samples != null)
                return samples;

            var sampleService = new PubgSamplesService(ApiKey);

            samples = sampleService.GetMatchSamples(region);

            StoredItems.Add(samples);

            return samples;
        }

        public static PubgPlayer GetPlayer(PubgPlatform platform)
        {
            var player = StoredItems.OfType<PubgPlayer>().FirstOrDefault(p => p.ShardId == platform.Serialize());

            if (player != null)
                return player;
            
            var playerService = new PubgPlayerService(ApiKey);

            var region = platform == PubgPlatform.Xbox ? PubgRegion.XboxEurope : PubgRegion.PCEurope;

            var playerNames = GetMatch(region).Rosters.SelectMany(r => r.Participants).Select(p => p.Stats.Name).Take(5);
            var players = playerService.GetPlayers(platform, new GetPubgPlayersRequest { PlayerNames = playerNames.ToArray() });

            StoredItems.AddRange(players);

            return players.FirstOrDefault();
        }

        public static PubgMatch GetMatch(PubgRegion region)
        {
            var match = StoredItems.OfType<PubgMatch>().FirstOrDefault(p => p.ShardId == region.Serialize());

            if (match != null)
                return match;

            var samples = GetSamples(region);
            var matchService = new PubgMatchService(ApiKey);

            if (region.IsPC())
                match = matchService.GetMatchPC(samples.MatchIds.First());
            else if(region.IsXbox())
                match = matchService.GetMatchXbox(region, samples.MatchIds.First());

            StoredItems.Add(match);

            return match;
        }

        public static PubgSeason GetSeason(PubgRegion region)
        {
            PubgSeason season = null;

            if(region.IsXbox())
                season = StoredItems.OfType<PubgSeason>().FirstOrDefault(p => p.Id.ToLowerInvariant().Contains("xb"));
            else if(region.IsPC())
                season = StoredItems.OfType<PubgSeason>().FirstOrDefault(p => !p.Id.ToLowerInvariant().Contains("xb"));

            if (season != null)
                return season;

            var seasonService = new PubgSeasonService(ApiKey);
            List<PubgSeason> seasons = new List<PubgSeason>();

            if (region.IsPC())
                seasons = seasonService.GetSeasonsPC().ToList();
            else if (region.IsXbox())
                seasons = seasonService.GetSeasonsXbox(region).ToList();

            seasons.ForEach(s => StoredItems.Add(s));

            return seasons.LastOrDefault();
        }
    }
}

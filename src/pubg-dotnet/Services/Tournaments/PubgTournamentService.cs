using JsonApiSerializer;
using Newtonsoft.Json;
using Pubg.Net.Infrastructure;
using Pubg.Net.Services;
using Pubg.Net.Values;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Pubg.Net
{
    public class PubgTournamentService : PubgService
    {
        public PubgTournamentService() : base() { }
        public PubgTournamentService(string apiKey) : base(apiKey) { }

        public virtual IEnumerable<PubgTournament> GetTournaments(string apiKey = null)
        {
            var url = Api.Tournaments.TournamentsEndpoint();
            apiKey = string.IsNullOrEmpty(apiKey) ? ApiKey : apiKey;

            var matchJson = HttpRequestor.GetString(url, apiKey);

            return JsonConvert.DeserializeObject<IEnumerable<PubgTournament>>(matchJson, new JsonApiSerializerSettings());
        }

        public async virtual Task<IEnumerable<PubgTournament>> GetTournamentsAsync(string apiKey = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            var url = Api.Tournaments.TournamentsEndpoint();
            apiKey = string.IsNullOrEmpty(apiKey) ? ApiKey : apiKey;

            var matchJson = await HttpRequestor.GetStringAsync(url, cancellationToken, apiKey);

            return JsonConvert.DeserializeObject<IEnumerable<PubgTournament>>(matchJson, new JsonApiSerializerSettings());
        }

        public virtual PubgTournament GetTournament(string tournamentId, string apiKey = null)
        {
            var url = Api.Tournaments.TournamentsEndpoint(tournamentId);
            apiKey = string.IsNullOrEmpty(apiKey) ? ApiKey : apiKey;

            var matchJson = HttpRequestor.GetString(url, apiKey);

            return JsonConvert.DeserializeObject<PubgTournament>(matchJson, new JsonApiSerializerSettings());
        }

        public async virtual Task<PubgTournament> GetTournamentAsync(string tournamentId, string apiKey = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            var url = Api.Tournaments.TournamentsEndpoint(tournamentId);
            apiKey = string.IsNullOrEmpty(apiKey) ? ApiKey : apiKey;

            var matchJson = await HttpRequestor.GetStringAsync(url, cancellationToken, apiKey);

            return JsonConvert.DeserializeObject<PubgTournament>(matchJson, new JsonApiSerializerSettings());
        }
    }
}

using System.Collections.Generic;
using System.Threading.Tasks;
using Tinder.Api.Infrastructure.Application.Interfaces;
using Tinder.Api.Infrastructure.Domain.Interfaces;
using Tinder.Api.Infrastructure.Repository.Interfaces;

namespace Tinder.Api.Infrastructure.Application
{
    public sealed class MatchesApplication : IMatchesApplication
    {
        private readonly IMatchesRepository _matchesRepository;

        public MatchesApplication(IMatchesRepository matchesRepository)
        {
            _matchesRepository = matchesRepository;
        }

        public async Task<IEnumerable<IMatch>> Get(long userId)
        {
            return await _matchesRepository.Get(userId);
        }
    }
}
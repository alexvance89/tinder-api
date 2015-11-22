using System.Collections.Generic;
using System.Threading.Tasks;
using Tinder.Api.Infrastructure.Application.Interfaces;
using Tinder.Api.Infrastructure.Domain.Interfaces;
using Tinder.Api.Infrastructure.Repository.Interfaces;

namespace Tinder.Api.Infrastructure.Application
{
    public sealed class DiscoveriesApplication : IDiscoveriesApplication
    {
        private readonly IDiscoveriesRepository _discoveriesRepository;

        public DiscoveriesApplication(IDiscoveriesRepository discoveriesRepository)
        {
            _discoveriesRepository = discoveriesRepository;
        }

        public async Task<IEnumerable<IDiscovery>> GetDiscoveries(long currentUserId)
        {
            return await _discoveriesRepository.GetDiscoveries(currentUserId);
        }
        
        public async Task Like(long currentUserId, long userId)
        {
            await _discoveriesRepository.Like(currentUserId, userId);
        }

        public async Task Dislike(long currentUserId, long userId)
        {
            await _discoveriesRepository.Dislike(currentUserId, userId);
        }
    }
}
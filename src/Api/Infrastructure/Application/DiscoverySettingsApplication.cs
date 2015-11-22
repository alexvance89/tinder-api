using System.Threading.Tasks;
using Tinder.Api.Infrastructure.Application.Interfaces;
using Tinder.Api.Infrastructure.Domain.Interfaces;
using Tinder.Api.Infrastructure.Repository.Interfaces;

namespace Tinder.Api.Infrastructure.Application
{
    public sealed class DiscoverySettingsApplication : IDiscoverySettingsApplication
    {
        private readonly IDiscoverySettingsRepository _discoverySettingsRepository;

        public DiscoverySettingsApplication(IDiscoverySettingsRepository discoverySettingsRepository)
        {
            _discoverySettingsRepository = discoverySettingsRepository;
        }

        public async Task<IDiscoverySettings> Get(long userId)
        {
            return await _discoverySettingsRepository.Get(userId);
        }

        public async Task Put(long userId, IDiscoverySettings discoverySettings)
        {
            await _discoverySettingsRepository.Put(userId, discoverySettings);
        }
    }
}
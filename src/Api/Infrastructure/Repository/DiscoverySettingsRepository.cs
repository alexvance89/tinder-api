using System.Threading.Tasks;
using Tinder.Api.Infrastructure.Domain;
using Tinder.Api.Infrastructure.Domain.Enums;
using Tinder.Api.Infrastructure.Domain.Interfaces;
using Tinder.Api.Infrastructure.Repository.Interfaces;

namespace Tinder.Api.Infrastructure.Repository
{
    public sealed class DiscoverySettingsRepository : IDiscoverySettingsRepository
    {
        private readonly IDiscoverySettings _discoverySettings = new DiscoverySettings
        {
            DiscoveryEnabled = true,
            SearchDistanceMiles = 25,
            SearchLocationLatitude = 96.6992,
            SearchLocationLongitude = 33.0197,
            ShowAgeMax = 27,
            ShowAgeMin = 23,
            ShowMe = Gender.Both
        };

        public async Task<IDiscoverySettings> Get(long userId)
        {
            var task = await Task.Factory.StartNew(() => _discoverySettings);

            await Task.Delay(50);

            return task;
        }

        public async Task Put(long userId, IDiscoverySettings discoverySettings)
        {
            await Task.Delay(50);
        }
    }
}
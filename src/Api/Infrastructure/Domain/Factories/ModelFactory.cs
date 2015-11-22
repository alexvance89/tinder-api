using Tinder.Api.Infrastructure.Domain.Factories.Interfaces;
using Tinder.Api.Infrastructure.Domain.Interfaces;

namespace Tinder.Api.Infrastructure.Domain.Factories
{
    public sealed class ModelFactory : IModelFactory
    {
        public IDiscoverySettings CreateDiscoverySettings()
        {
            return new DiscoverySettings();
        }
    }
}
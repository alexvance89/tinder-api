using Tinder.Api.Infrastructure.Domain.Interfaces;

namespace Tinder.Api.Infrastructure.Domain.Factories.Interfaces
{
    public interface IModelFactory
    {
        IDiscoverySettings CreateDiscoverySettings();
    }
}
using Tinder.Api.Contracts;
using Tinder.Api.Infrastructure.Domain.Interfaces;

namespace Tinder.Api.Mappers.Interfaces
{
    public interface IDiscoverySettingsMapper
    {
        IDiscoverySettings ToModel(DiscoverySettingsContract contract);
        DiscoverySettingsContract ToContract(IDiscoverySettings model);
    }
}
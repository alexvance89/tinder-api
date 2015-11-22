using Tinder.Api.Contracts;
using Tinder.Api.Infrastructure.Domain.Interfaces;

namespace Tinder.Api.Mappers.Interfaces
{
    public interface IDiscoveryMapper
    {
        DiscoveryContract ToContract(IDiscovery model);
    }
}
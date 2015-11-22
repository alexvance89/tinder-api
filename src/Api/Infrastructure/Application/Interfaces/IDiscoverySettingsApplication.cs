using System.Threading.Tasks;
using Tinder.Api.Infrastructure.Domain.Interfaces;

namespace Tinder.Api.Infrastructure.Application.Interfaces
{
    public interface IDiscoverySettingsApplication
    {
        Task<IDiscoverySettings> Get(long userId);
        Task Put(long userId, IDiscoverySettings discoverySettings);
    }
}
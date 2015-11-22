using System.Threading.Tasks;
using Tinder.Api.Infrastructure.Domain.Interfaces;

namespace Tinder.Api.Infrastructure.Repository.Interfaces
{
    public interface IDiscoverySettingsRepository
    {
        Task<IDiscoverySettings> Get(long userId);
        Task Put(long userId, IDiscoverySettings discoverySettings);
    }
}
using System.Collections.Generic;
using System.Threading.Tasks;
using Tinder.Api.Infrastructure.Domain.Interfaces;

namespace Tinder.Api.Infrastructure.Repository.Interfaces
{
    public interface IDiscoveriesRepository
    {
        Task<IEnumerable<IDiscovery>> GetDiscoveries(long currentUserId);
        Task Like(long currentUserId, long userId);
        Task Dislike(long currentUserId, long userId);
    }
}
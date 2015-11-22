using System.Collections.Generic;
using System.Threading.Tasks;
using Tinder.Api.Infrastructure.Domain.Interfaces;

namespace Tinder.Api.Infrastructure.Repository.Interfaces
{
    public interface IMatchesRepository
    {
        Task<IEnumerable<IMatch>> Get(long userId);
    }
}
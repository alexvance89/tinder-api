using System.Collections.Generic;
using System.Threading.Tasks;
using Tinder.Api.Infrastructure.Domain.Interfaces;

namespace Tinder.Api.Infrastructure.Application.Interfaces
{
    public interface IMatchesApplication
    {
        Task<IEnumerable<IMatch>> Get(long userId);
    }
}
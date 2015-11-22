using System.Threading.Tasks;
using Tinder.Api.Infrastructure.Domain.Interfaces;

namespace Tinder.Api.Infrastructure.Application.Interfaces
{
    public interface IUsersApplication
    {
        Task<IUser> Get(long userId);
    }
}
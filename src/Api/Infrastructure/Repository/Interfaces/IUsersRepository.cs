using System.Threading.Tasks;
using Tinder.Api.Infrastructure.Domain.Interfaces;

namespace Tinder.Api.Infrastructure.Repository.Interfaces
{
    public interface IUsersRepository
    {
        Task<IUser> Get(long userId);
    }
}
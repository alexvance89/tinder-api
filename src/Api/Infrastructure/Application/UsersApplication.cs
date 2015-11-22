using System.Threading.Tasks;
using Tinder.Api.Infrastructure.Application.Interfaces;
using Tinder.Api.Infrastructure.Domain.Interfaces;
using Tinder.Api.Infrastructure.Repository.Interfaces;

namespace Tinder.Api.Infrastructure.Application
{
    public sealed class UsersApplication : IUsersApplication
    {
        private readonly IUsersRepository _usersRepository;

        public UsersApplication(IUsersRepository usersRepository)
        {
            _usersRepository = usersRepository;
        }

        public async Task<IUser> Get(long userId)
        {
            return await _usersRepository.Get(userId);
        }
    }
}
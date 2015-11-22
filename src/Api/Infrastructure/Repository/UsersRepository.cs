using System.Collections.Generic;
using System.Threading.Tasks;
using Tinder.Api.Infrastructure.Domain;
using Tinder.Api.Infrastructure.Domain.Enums;
using Tinder.Api.Infrastructure.Domain.Interfaces;
using Tinder.Api.Infrastructure.Repository.Interfaces;

namespace Tinder.Api.Infrastructure.Repository
{
    public sealed class UsersRepository : IUsersRepository
    {
        private readonly IUser _user = new User
        {
            Id = 67891,
            About = "Big time four wheeling champion.",
            Age = 23,
            Name = "John Smith",
            Work = "Four Wheeler",
            Gender = Gender.Male,
            Photos = new List<IPhoto>
            {
                new Photo { Id = 987654321, Url = "http://cdn.tinder.com/user/67891/987654321.jpg" },
                new Photo { Id = 987654322, Url = "http://cdn.tinder.com/user/67891/987654322.jpg" }
            }
        };

        public async Task<IUser> Get(long userId)
        {
            var task = await Task.Factory.StartNew(() => _user);

            await Task.Delay(50);

            return task;
        }
    }
}
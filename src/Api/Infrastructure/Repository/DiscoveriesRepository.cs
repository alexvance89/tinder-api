using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Tinder.Api.Infrastructure.Domain;
using Tinder.Api.Infrastructure.Domain.Enums;
using Tinder.Api.Infrastructure.Domain.Interfaces;
using Tinder.Api.Infrastructure.Repository.Interfaces;

namespace Tinder.Api.Infrastructure.Repository
{
    /// <summary>
    /// Typically, this class would contain the implementation for any database interactions. 
    /// For simplicity sake, I've left the ADO.NET implementation out to serve up fake data.
    /// </summary>
    public sealed class DiscoveriesRepository : IDiscoveriesRepository
    {
        private readonly IEnumerable<IDiscovery> _discoveries = new List<IDiscovery>
        {
            new Discovery
            {
                User = new User
                {
                    Id = 12345,
                    About = "I enjoy long walks on the beach.",
                    Age = 27,
                    Name = "Jane Doe",
                    Work = "International Spy",
                    Gender = Gender.Female,
                    Photos = new List<IPhoto>
                    {
                        new Photo { Id = 123456789, Url = "http://cdn.tinder.com/user/12345/123456789.jpg" }
                    }
                },
                CommonFriends = new List<IFriend>(),
                CommonInterests = new List<IInterest>
                {
                    new Interest { Id = 54321, Value = "Beach" }
                },
                DistanceInMiles = 5

            },
            new Discovery
            {
                User = new User
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
                },
                CommonFriends = new List<IFriend>
                {
                    new Friend { Id = 12345, Photo = new Photo { Id = 123456789, Url = "http://cdn.tinder.com/user/12345/123456789.jpg" } }
                },
                CommonInterests = new List<IInterest>(),
                DistanceInMiles = 13
            }
        };


        /// <summary>
        /// Executes with a Thread.Sleep(50) to emulate a database call.
        /// </summary>
        public async Task<IEnumerable<IDiscovery>> GetDiscoveries(long currentUserId)
        {
            var task = await Task.Factory.StartNew(() => _discoveries);

            await Task.Delay(50);
            return task;
        }

        public async Task Like(long currentUserId, long userId)
        {
            await Task.Delay(50);
        }

        public async Task Dislike(long currentUserId, long userId)
        {
            await Task.Delay(50);
        }
    }
}
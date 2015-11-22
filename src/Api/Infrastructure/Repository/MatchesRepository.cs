using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Tinder.Api.Infrastructure.Domain;
using Tinder.Api.Infrastructure.Domain.Interfaces;
using Tinder.Api.Infrastructure.Repository.Interfaces;

namespace Tinder.Api.Infrastructure.Repository
{
    public sealed class MatchesRepository : IMatchesRepository
    {
        private readonly IEnumerable<IMatch> _matches = new List<IMatch>
        {
            new Match
            {
                Id = 12345,
                Created = DateTime.Now.AddDays(-1),
                UserId = 56789,
                Messages = new List<IMessage>
                {
                    new Message
                    {
                        Id = 654353,
                        Created = DateTime.Now.AddHours(-5),
                        To = 56789,
                        From = default(long),
                        Contents = "Hey, we matched!"
                    },
                    new Message
                    {
                        Id = 499802,
                        Created = DateTime.Now.AddHours(-4),
                        To = default(long),
                        From = 56789,
                        Contents = "I know, it's super exciting!"
                    }
                }
            },
            new Match
            {
                Id = 12346,
                Created = DateTime.Now.AddDays(-5),
                UserId = 14439,
                Messages = new List<IMessage>()
            }
        };

        public async Task<IEnumerable<IMatch>> Get(long userId)
        {
            var task = await Task.Factory.StartNew(() => _matches);

            await Task.Delay(50);

            return task;
        }
    }
}
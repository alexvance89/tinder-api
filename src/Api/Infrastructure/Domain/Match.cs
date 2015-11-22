using System;
using System.Collections.Generic;
using Tinder.Api.Infrastructure.Domain.Interfaces;

namespace Tinder.Api.Infrastructure.Domain
{
    public sealed class Match : IMatch
    {
        public long Id { get; set; }
        public long UserId { get; set; }
        public DateTime Created { get; set; }
        public IEnumerable<IMessage> Messages { get; set; }
    }
}
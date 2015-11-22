using System;
using System.Collections.Generic;

namespace Tinder.Api.Contracts
{
    public sealed class MatchContract
    {
        public long Id { get; set; }
        public long UserId { get; set; }
        public DateTime Created { get; set; }
        public IEnumerable<MessageContract> Messages { get; set; }
    }
}
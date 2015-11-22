using System;
using System.Collections.Generic;

namespace Tinder.Api.Infrastructure.Domain.Interfaces
{
    public interface IMatch
    {
        long Id { get; set; }
        long UserId { get; set; }
        DateTime Created { get; set; }
        IEnumerable<IMessage> Messages { get; set; }
    }
}
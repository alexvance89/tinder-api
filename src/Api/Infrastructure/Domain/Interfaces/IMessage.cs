using System;

namespace Tinder.Api.Infrastructure.Domain.Interfaces
{
    public interface IMessage
    {
        long Id { get; set; }
        long To { get; set; }
        long From { get; set; }
        string Contents { get; set; }
        DateTime Created { get; set; }
    }
}
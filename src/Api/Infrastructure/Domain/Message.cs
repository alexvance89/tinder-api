using System;
using Tinder.Api.Infrastructure.Domain.Interfaces;

namespace Tinder.Api.Infrastructure.Domain
{
    public sealed class Message : IMessage
    {
        public long Id { get; set; }
        public long To { get; set; }
        public long From { get; set; }
        public string Contents { get; set; }
        public DateTime Created { get; set; }
    }
}
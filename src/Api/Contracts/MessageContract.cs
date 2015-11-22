using System;

namespace Tinder.Api.Contracts
{
    public sealed class MessageContract
    {
        public long Id { get; set; }
        public long To { get; set; }
        public long From { get; set; }
        public string Contents { get; set; }
        public DateTime Created { get; set; }
    }
}
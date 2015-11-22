using System;

namespace Tinder.Api.Contracts
{
    public sealed class FriendContract
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public PhotoContract Photo { get; set; }

    }
}
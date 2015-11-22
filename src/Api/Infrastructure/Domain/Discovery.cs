using System.Collections.Generic;
using Tinder.Api.Infrastructure.Domain.Interfaces;

namespace Tinder.Api.Infrastructure.Domain
{
    public sealed class Discovery : IDiscovery
    {
        public IUser User { get; set; }
        public int DistanceInMiles { get; set; }
        public IEnumerable<IFriend> CommonFriends { get; set; }
        public IEnumerable<IInterest> CommonInterests { get; set; }
    }
}
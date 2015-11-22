using System.Collections.Generic;

namespace Tinder.Api.Contracts
{
    public sealed class DiscoveryContract
    {
        public UserContract User { get; set; } 
        public int DistanceInMiles { get; set; }
        public IEnumerable<FriendContract> CommonFriends { get; set; }
        public IEnumerable<InterestContract> CommonInterests { get; set; }
    }
}
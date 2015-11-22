using System.Collections.Generic;

namespace Tinder.Api.Infrastructure.Domain.Interfaces
{
    public interface IDiscovery
    {
        IUser User { get; set; }
        int DistanceInMiles { get; set; }
        IEnumerable<IFriend> CommonFriends { get; set; }
        IEnumerable<IInterest> CommonInterests { get; set; }
    }
}
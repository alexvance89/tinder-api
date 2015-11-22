using Tinder.Api.Infrastructure.Domain.Enums;

namespace Tinder.Api.Infrastructure.Domain.Interfaces
{
    public interface IDiscoverySettings
    {
        bool DiscoveryEnabled { get; set; }
        Gender ShowMe { get; set; }
        int SearchDistanceMiles { get; set; }
        double SearchLocationLatitude { get; set; }
        double SearchLocationLongitude { get; set; }
        int ShowAgeMin { get; set; }
        int ShowAgeMax { get; set; }
    }
}
using Tinder.Api.Infrastructure.Domain.Enums;
using Tinder.Api.Infrastructure.Domain.Interfaces;

namespace Tinder.Api.Infrastructure.Domain
{
    public sealed class DiscoverySettings : IDiscoverySettings
    {
        public bool DiscoveryEnabled { get; set; }
        public Gender ShowMe { get; set; }
        public int SearchDistanceMiles { get; set; }
        public double SearchLocationLatitude { get; set; }
        public double SearchLocationLongitude { get; set; }
        public int ShowAgeMin { get; set; }
        public int ShowAgeMax { get; set; }
    }
}
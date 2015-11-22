namespace Tinder.Api.Contracts
{
    public sealed class DiscoverySettingsContract
    {
        public bool DiscoveryEnabled { get; set; }
        public GenderContract ShowMe { get; set; }
        public int SearchDistanceMiles { get; set; }
        public double SearchLocationLatitude { get; set; }
        public double SearchLocationLongitude { get; set; }
        public int ShowAgeMin { get; set; }
        public int ShowAgeMax { get; set; }
    }
}
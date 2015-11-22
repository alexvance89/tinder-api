using Tinder.Api.Contracts;
using Tinder.Api.Infrastructure.Domain.Enums;
using Tinder.Api.Infrastructure.Domain.Factories.Interfaces;
using Tinder.Api.Infrastructure.Domain.Interfaces;
using Tinder.Api.Mappers.Interfaces;

namespace Tinder.Api.Mappers
{
    public sealed class DiscoverySettingsMapper : IDiscoverySettingsMapper
    {
        private readonly IModelFactory _modelFactory;

        public DiscoverySettingsMapper(IModelFactory modelFactory)
        {
            _modelFactory = modelFactory;
        }

        public IDiscoverySettings ToModel(DiscoverySettingsContract contract)
        {
            var model = _modelFactory.CreateDiscoverySettings();

            model.ShowMe = (Gender)((int) contract.ShowMe);
            model.DiscoveryEnabled = contract.DiscoveryEnabled;
            model.SearchDistanceMiles = contract.SearchDistanceMiles;
            model.SearchLocationLatitude = contract.SearchLocationLatitude;
            model.SearchLocationLongitude = contract.SearchLocationLongitude;
            model.ShowAgeMax = contract.ShowAgeMax;
            model.ShowAgeMin = contract.ShowAgeMin;

            return model;
        }

        public DiscoverySettingsContract ToContract(IDiscoverySettings model)
        {
            var contract = new DiscoverySettingsContract
            {
                DiscoveryEnabled = model.DiscoveryEnabled,
                SearchLocationLongitude = model.SearchLocationLongitude,
                SearchLocationLatitude = model.SearchLocationLatitude,
                ShowAgeMax = model.ShowAgeMax,
                ShowAgeMin = model.ShowAgeMin,
                ShowMe = (GenderContract) ((int) model.ShowMe),
                SearchDistanceMiles = model.SearchDistanceMiles
            };

            return contract;
        }
    }
}
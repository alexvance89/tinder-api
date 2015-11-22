using Tinder.Api.Contracts;
using Tinder.Api.Infrastructure.Domain.Interfaces;
using Tinder.Api.Mappers.Interfaces;

namespace Tinder.Api.Mappers
{
    public sealed class PhotoMapper : IPhotoMapper
    {
        public PhotoContract ToContract(IPhoto model)
        {
            var contract = new PhotoContract
            {
                Id = model.Id,
                Url = model.Url
            };

            return contract;
        }
    }
}
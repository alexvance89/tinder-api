using Tinder.Api.Contracts;
using Tinder.Api.Infrastructure.Domain.Interfaces;
using Tinder.Api.Mappers.Interfaces;

namespace Tinder.Api.Mappers
{
    public sealed class FriendMapper : IFriendMapper
    {
        private readonly IPhotoMapper _photoMapper;

        public FriendMapper(IPhotoMapper photoMapper)
        {
            _photoMapper = photoMapper;
        }

        public FriendContract ToContract(IFriend model)
        {
            var contract = new FriendContract
            {
                Id = model.Id,
                Name = model.Name
            };

            if (model.Photo != null)
            {
                contract.Photo = _photoMapper.ToContract(model.Photo);
            }

            return contract;
        }
    }
}
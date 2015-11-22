using System;
using System.Linq;
using Tinder.Api.Contracts;
using Tinder.Api.Infrastructure.Domain.Interfaces;
using Tinder.Api.Mappers.Interfaces;

namespace Tinder.Api.Mappers
{
    public sealed class UserMapper : IUserMapper
    {
        private readonly IPhotoMapper _photoMapper;

        public UserMapper(IPhotoMapper photoMapper)
        {
            _photoMapper = photoMapper;
        }

        public UserContract ToContract(IUser model)
        {
            var contract = new UserContract
            {
                Id = model.Id,
                About = model.About,
                Age = model.Age,
                Gender = (GenderContract) ((int) model.Gender),
                Name = model.Name,
                Work = model.Work
            };

            if (model.Photos != null)
            {
                contract.Photos = model.Photos.Select(_photoMapper.ToContract);
            }

            return contract;
        }
    }
}
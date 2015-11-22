using System.Linq;
using Tinder.Api.Contracts;
using Tinder.Api.Infrastructure.Domain.Interfaces;
using Tinder.Api.Mappers.Interfaces;

namespace Tinder.Api.Mappers
{
    public sealed class DiscoveryMapper : IDiscoveryMapper
    {
        private readonly IUserMapper _userMapper;
        private readonly IFriendMapper _friendMapper;
        private readonly IInterestMapper _interestMapper;

        public DiscoveryMapper(IUserMapper userMapper, IFriendMapper friendMapper, IInterestMapper interestMapper)
        {
            _userMapper = userMapper;
            _friendMapper = friendMapper;
            _interestMapper = interestMapper;
        }

        public DiscoveryContract ToContract(IDiscovery model)
        {
            var contract = new DiscoveryContract
            {
                DistanceInMiles = model.DistanceInMiles
            };

            if (model.User != null)
            {
                contract.User = _userMapper.ToContract(model.User);
            }

            if (model.CommonFriends != null)
            {
                contract.CommonFriends = model.CommonFriends.Select(_friendMapper.ToContract);
            }

            if (model.CommonInterests != null)
            {
                contract.CommonInterests = model.CommonInterests.Select(_interestMapper.ToContract);
            }
            
            return contract;
        }
    }
}
using Tinder.Api.Contracts;
using Tinder.Api.Infrastructure.Domain.Interfaces;

namespace Tinder.Api.Mappers.Interfaces
{
    public interface IFriendMapper
    {
        FriendContract ToContract(IFriend model);
    }
}
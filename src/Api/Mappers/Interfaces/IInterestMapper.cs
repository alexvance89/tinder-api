using Tinder.Api.Contracts;
using Tinder.Api.Infrastructure.Domain.Interfaces;

namespace Tinder.Api.Mappers.Interfaces
{
    public interface IInterestMapper
    {
        InterestContract ToContract(IInterest model);
    }
}
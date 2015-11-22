using Tinder.Api.Contracts;
using Tinder.Api.Infrastructure.Domain.Interfaces;

namespace Tinder.Api.Mappers.Interfaces
{
    public interface IMatchMapper
    {
        MatchContract ToContract(IMatch model);
    }
}
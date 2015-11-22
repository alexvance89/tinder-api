using Tinder.Api.Contracts;
using Tinder.Api.Infrastructure.Domain.Interfaces;
using Tinder.Api.Mappers.Interfaces;

namespace Tinder.Api.Mappers
{
    public sealed class InterestMapper : IInterestMapper
    {
        public InterestContract ToContract(IInterest model)
        {
            var contract = new InterestContract
            {
                Id = model.Id,
                Value = model.Value
            };

            return contract;
        }
    }
}
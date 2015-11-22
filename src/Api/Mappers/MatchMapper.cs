using System.Linq;
using Tinder.Api.Contracts;
using Tinder.Api.Infrastructure.Domain.Factories.Interfaces;
using Tinder.Api.Infrastructure.Domain.Interfaces;
using Tinder.Api.Mappers.Interfaces;

namespace Tinder.Api.Mappers
{
    public sealed class MatchMapper : IMatchMapper
    {
        private readonly IMessageMapper _messageMapper;
        public MatchMapper(IMessageMapper messageMapper)
        {
            _messageMapper = messageMapper;
        }
        public MatchContract ToContract(IMatch model)
        {
            var contract = new MatchContract
            {
                Id = model.Id,
                Created = model.Created,
                UserId = model.UserId
            };

            if (model.Messages != null)
            {
                contract.Messages = model.Messages.Select(_messageMapper.ToContract);
            }

            return contract;
        }
    }
}
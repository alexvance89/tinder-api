using Tinder.Api.Contracts;
using Tinder.Api.Infrastructure.Domain.Factories.Interfaces;
using Tinder.Api.Infrastructure.Domain.Interfaces;
using Tinder.Api.Mappers.Interfaces;

namespace Tinder.Api.Mappers
{
    public sealed class MessageMapper : IMessageMapper
    {
        private readonly IModelFactory _modelFactory;

        public MessageMapper(IModelFactory modelFactory)
        {
            _modelFactory = modelFactory;
        }

        public MessageContract ToContract(IMessage model)
        {
            var contract = new MessageContract
            {
                Id = model.Id,
                Created = model.Created,
                From = model.From,
                To = model.To,
                Contents = model.Contents
            };

            return contract;
        }
    }
}
using Tinder.Api.Infrastructure.Domain.Interfaces;

namespace Tinder.Api.Infrastructure.Domain
{
    public sealed class Friend : IFriend
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public IPhoto Photo { get; set; }
    }
}
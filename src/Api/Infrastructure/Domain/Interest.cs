using Tinder.Api.Infrastructure.Domain.Interfaces;

namespace Tinder.Api.Infrastructure.Domain
{
    public sealed class Interest : IInterest
    {
        public long Id { get; set; }
        public string Value { get; set; }
    }
}
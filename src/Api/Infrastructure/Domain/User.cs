using System.Collections.Generic;
using Tinder.Api.Infrastructure.Domain.Enums;
using Tinder.Api.Infrastructure.Domain.Interfaces;

namespace Tinder.Api.Infrastructure.Domain
{
    public sealed class User : IUser
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string About { get; set; }
        public string Work { get; set; }
        public int Age { get; set; }
        public Gender Gender { get; set; }
        public IEnumerable<IPhoto> Photos { get; set; }
    }
}
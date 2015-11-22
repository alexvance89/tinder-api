using System.Collections.Generic;
using Tinder.Api.Infrastructure.Domain.Enums;

namespace Tinder.Api.Infrastructure.Domain.Interfaces
{
    public interface IUser
    {
        long Id { get; set; }
        string Name { get; set; }
        string About { get; set; }
        string Work { get; set; }
        int Age { get; set; }
        Gender Gender { get; set; }
        IEnumerable<IPhoto> Photos { get; set; }
    }
}
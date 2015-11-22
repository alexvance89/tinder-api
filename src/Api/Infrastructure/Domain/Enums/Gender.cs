using System;

namespace Tinder.Api.Infrastructure.Domain.Enums
{
    [Flags]
    public enum Gender
    {
        Male = 1,
        Female = 2,
        Both = 4
    }
}
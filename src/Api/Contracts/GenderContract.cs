using System;

namespace Tinder.Api.Contracts
{
    [Flags]
    public enum GenderContract
    {
         Male = 1,
         Female = 2,
         Both = 4
    }
}
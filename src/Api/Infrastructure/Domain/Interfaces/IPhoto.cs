using System;

namespace Tinder.Api.Infrastructure.Domain.Interfaces
{
    public interface IPhoto
    {
        long Id { get; set; }
        string Url { get; set; }
    }
}
using System;
using Tinder.Api.Infrastructure.Domain.Interfaces;

namespace Tinder.Api.Infrastructure.Domain
{
    public sealed class Photo : IPhoto
    {
        public long Id { get; set; }
        public string Url { get; set; }
    }
}
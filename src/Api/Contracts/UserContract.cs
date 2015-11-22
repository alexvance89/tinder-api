using System.Collections.Generic;

namespace Tinder.Api.Contracts
{
    public sealed class UserContract
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string About { get; set; }
        public string Work { get; set; }
        public int Age { get; set; }
        public GenderContract Gender { get; set; }
        public IEnumerable<PhotoContract> Photos { get; set; }
    }
}
namespace Tinder.Api.Infrastructure.Domain.Interfaces
{
    public interface IFriend
    {
        long Id { get; set; }
        string Name { get; set; }
        IPhoto Photo { get; set; }
    }
}
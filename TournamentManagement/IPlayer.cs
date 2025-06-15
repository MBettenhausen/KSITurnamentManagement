
namespace TournamentManagement
{
    public interface IPlayer
    {
        Guid Id { get; }
        string Name { get; }
        IRating Rating { get; }
    }

    public interface IRating
    {
    }
}
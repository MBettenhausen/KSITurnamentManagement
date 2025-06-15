
namespace TournamentManagement
{
    public interface ITournament
    {
        string Name { get; }

        IEnumerable<IPlayer> Players { get; }

        int NumberOfPlayers { get; }
    }
}


namespace TournamentManagement
{

    public class Tournament: ITournament
    {
        public string Name { get; }

        public IEnumerable<IPlayer> Players { get; private set; }

        public int NumberOfPlayers => this.Players.Count();

        public Tournament(String name, IEnumerable<IPlayer> players)
        {
            Name = name;
            Players = players;
        }
    }
}

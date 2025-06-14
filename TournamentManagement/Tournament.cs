namespace TournamentManagement
{

    public interface ITournament
    {
        string Name { get; }

        IEnumerable<IPlayer> Players { get; }

        int NumberOfPlayers { get; }
    }

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

    public class Player : IPlayer
    {
        public string Name { get; }
        public Guid Id { get; }

        public Player(string name)
        {
            Name = name;
            this.Id = Guid.NewGuid();
        }
    }
    public class Match { }
    public class  Round
    {
        
    }
}

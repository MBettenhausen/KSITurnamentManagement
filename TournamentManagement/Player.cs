
namespace TournamentManagement
{
    public class Player : IPlayer
    {
        public string Name { get; }
        public Guid Id { get; }

        public IRating Rating { get; }

        public Player(string name, IRating rating)
        {
            Name = name;
            this.Id = Guid.NewGuid();
            Rating = rating;
        }
    }
}

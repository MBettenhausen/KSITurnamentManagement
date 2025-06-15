
namespace TournamentManagement
{
    public interface IMatch
    {
        public IPlayer Player1 { get; }
        public IPlayer Player2 { get; }
        public IEnumerable<IGame> Games { get; }
    }
}

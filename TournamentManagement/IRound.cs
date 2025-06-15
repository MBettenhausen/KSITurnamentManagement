
namespace TournamentManagement
{
    public interface IRound
    {
        public IEnumerable<IMatch> Matches { get; }
    }
}

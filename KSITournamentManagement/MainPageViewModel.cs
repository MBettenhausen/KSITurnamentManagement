using System.Collections.ObjectModel;
using TournamentManagement;
namespace KSITournamentManagement
{
    public class MainPageViewModel
    {
        public IEnumerable<ITournament> Turnaments { get; set; } = new ObservableCollection<Tournament> {
            new Tournament("Turnament 1" , [new Player("Bob", new Rating()),
            new Player("Alice", new Rating())]),
            new Tournament("Turnament 2", [new Player("Bob", new Rating()), new Player("Alice", new Rating()), new Player("Tim", new Rating())]),
        };
        public MainPageViewModel()
        {
            
        }
    }
}

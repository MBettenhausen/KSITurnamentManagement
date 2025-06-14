using System.Collections.ObjectModel;
using TournamentManagement;
namespace KSITurnamentManagement
{
    public class MainPageViewModel
    {
        public IEnumerable<ITournament> Turnaments { get; set; } = new ObservableCollection<Tournament> {
            new Tournament("Turnament 1" , [new Player("Bob"),
            new Player("Alice")]),
            new Tournament("Turnament 2", [new Player("Bob"), new Player("Alice"), new Player("Tim")]),
        };
        public MainPageViewModel()
        {
            
        }
    }
}

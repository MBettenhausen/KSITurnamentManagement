using System.Collections.ObjectModel;
using TurnamentManagement;
namespace KSITurnamentManagement
{
    public class MainPageViewModel
    {
        public IEnumerable<ITurnament> Turnaments { get; set; } = new ObservableCollection<Turnament> {
            new Turnament("Turnament 1" , [new Player("Bob"),
            new Player("Alice")]),
            new Turnament("Turnament 2", [new Player("Bob"), new Player("Alice"), new Player("Tim")]),
        };
        public MainPageViewModel()
        {
            
        }
    }
}

using HSchedule.Stores;
using HSchedule.ViewModels.UserControls;

namespace HSchedule.Commands
{
    public class NavigateEntranceMenuCommand : CommandBase
    {
        private readonly NavigationStore _navigationStore;

        public NavigateEntranceMenuCommand(NavigationStore navigationStore) => _navigationStore = navigationStore;

        public override void Execute(object parameter)
        {
            _navigationStore.CurrentViewModel = new EntranceMenuViewModel(_navigationStore);
        }
    }
}

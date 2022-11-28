using HSchedule.Stores;
using HSchedule.ViewModels.UserControls;

namespace HSchedule.Commands
{
    public class NavigateMainMenuCommand : CommandBase
    {
        private readonly NavigationStore _navigationStore;

        public NavigateMainMenuCommand(NavigationStore navigationStore)
        {
            _navigationStore = navigationStore;
        }

        public override void Execute(object parameter)
        {
            _navigationStore.CurrentViewModel = new MainMenuViewModel(_navigationStore);
        }
    }
}

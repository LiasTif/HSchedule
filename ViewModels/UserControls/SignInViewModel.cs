using HSchedule.Commands;
using HSchedule.Stores;
using System.Windows.Input;

namespace HSchedule.ViewModels.UserControls
{
    public class SignInViewModel : ViewModelBase
    {
        #region commands
        public ICommand NavigateEntranceMenuCommand { get; }
        public ICommand NavigateMainMenuCommand { get; }
        #endregion

        public SignInViewModel(NavigationStore navigationStore)
        {
            NavigateEntranceMenuCommand = new NavigateEntranceMenuCommand(navigationStore);
            NavigateMainMenuCommand = new NavigateMainMenuCommand(navigationStore);
        }
    }
}

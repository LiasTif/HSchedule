using HSchedule.Stores;
using HSchedule.ViewModels.UserControls;

namespace HSchedule.Commands
{
    /// <summary>
    /// Navigate to SignInViewModel
    /// </summary>
    public class NavigateSignInCommand : CommandBase
    {
        private readonly NavigationStore _navigationStore;

        public NavigateSignInCommand(NavigationStore navigationStore)
        {
            _navigationStore = navigationStore;
        }

        public override void Execute(object parameter)
        {
            _navigationStore.CurrentViewModel = new SignInViewModel(_navigationStore);
        }
    }
}

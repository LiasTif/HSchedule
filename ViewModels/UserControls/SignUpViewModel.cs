using HSchedule.Commands;
using HSchedule.Stores;
using System.Windows.Input;

namespace HSchedule.ViewModels.UserControls
{
    public class SignUpViewModel : ViewModelBase
    {
        public ICommand NavigateSignInCommand { get; }
        public ICommand NavigateMainMenuCommand { get; }

        public SignUpViewModel(NavigationStore navigationStore)
        {
            NavigateSignInCommand = new NavigateSignInCommand(navigationStore);
            NavigateMainMenuCommand = new NavigateMainMenuCommand(navigationStore);
        }
    }
}
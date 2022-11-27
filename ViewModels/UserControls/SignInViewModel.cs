using HSchedule.Commands;
using HSchedule.Stores;
using System.Windows.Input;

namespace HSchedule.ViewModels.UserControls
{
    public class SignInViewModel : ViewModelBase
    {
        public ICommand NavigateSignUpCommand { get; }

        public SignInViewModel(NavigationStore navigationStore)
        {
            NavigateSignUpCommand = new NavigateSignUpCommand(navigationStore);
        }
    }
}

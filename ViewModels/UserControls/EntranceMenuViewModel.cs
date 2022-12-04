using HSchedule.Commands;
using HSchedule.Stores;
using System.Windows.Input;

namespace HSchedule.ViewModels.UserControls
{
    public class EntranceMenuViewModel : ViewModelBase
    {
        public ICommand NavigateSignUpCommand { get; }
        public ICommand NavigateSignInCommand { get; }

        public EntranceMenuViewModel(NavigationStore navigationStore)
        {
            NavigateSignUpCommand = new NavigateSignUpCommand(navigationStore);
            NavigateSignInCommand = new NavigateSignInCommand(navigationStore);
        }
    }
}

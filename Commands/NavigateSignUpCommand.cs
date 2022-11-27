using HSchedule.Stores;
using HSchedule.ViewModels.UserControls;

namespace HSchedule.Commands
{
    public class NavigateSignUpCommand : CommandBase
    {
        private readonly NavigationStore _navigationStore;

        public NavigateSignUpCommand(NavigationStore navigationStore)
        {
            _navigationStore = navigationStore;
        }

        public override void Execute(object parameter)
        {
            _navigationStore.CurrentViewModel = new SignUpViewModel(_navigationStore);
        }
    }
}
using HSchedule.Commands;
using HSchedule.Stores;
using System.Windows.Input;

namespace HSchedule.ViewModels.UserControls
{
    public class MainMenuViewModel : ViewModelBase
    {
        public ICommand AppExitCommand { get; }

        public MainMenuViewModel(NavigationStore navigationStore)
        {
            AppExitCommand = new AppExitCommand();
        }
    }
}

using HSchedule.Models.DataBase;
using HSchedule.Stores;
using HSchedule.ViewModels.UserControls;

namespace HSchedule.Commands
{
    /// <summary>
    /// Navigate to MainMenuViewModel and serialize person
    /// </summary>
    public class NavigateMainMenuAndSerializeCommand : CommandBase
    {
        readonly PersonSerialization personSerialization = new PersonSerialization();
        private readonly NavigationStore _navigationStore;

        public NavigateMainMenuAndSerializeCommand(NavigationStore navigationStore) => _navigationStore = navigationStore;

        public override void Execute(object parameter)
        {
            // navigate to MainMenuViewModel
            _navigationStore.CurrentViewModel = new MainMenuViewModel(_navigationStore);

            // serialize person
            personSerialization.CreateNewPerson();
        }
    }
}

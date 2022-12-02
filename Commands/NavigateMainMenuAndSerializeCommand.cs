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
        PersonSerialization personSerialization = new PersonSerialization();

        private readonly NavigationStore _navigationStore;
        private readonly SignUpViewModel _signUpViewModel;

        public NavigateMainMenuAndSerializeCommand(NavigationStore navigationStore)
        {
            _navigationStore = navigationStore;
        }

        public override void Execute(object parameter)
        {
            _navigationStore.CurrentViewModel = new MainMenuViewModel(_navigationStore);

            //_signUpViewModel.PersonPinGeneral += _signUpViewModel.PersonPin1 += _signUpViewModel.PersonPin2 +=
            //    _signUpViewModel.PersonPin3 += _signUpViewModel.PersonPin4;

            personSerialization.CreateNewPerson(_signUpViewModel.PersonFName, _signUpViewModel.PersonLName,
                _signUpViewModel.PersonPinGeneral);
        }
    }
}

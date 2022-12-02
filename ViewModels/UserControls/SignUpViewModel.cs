using HSchedule.Commands;
using HSchedule.Stores;
using System.Windows.Input;

namespace HSchedule.ViewModels.UserControls
{
    public class SignUpViewModel : ViewModelBase
    {
        #region properties
        public string PersonFName { get; set; }

        //public string PersonFName { get; set; }
        public string PersonLName { get; set; }
        public string PersonPinGeneral { get; set; }

        public string PersonPin1 { get; set; }
        public string PersonPin2 { get; set; }
        public string PersonPin3 { get; set; }
        public string PersonPin4 { get; set; }
        #endregion


        #region commands
        public ICommand NavigateSignInCommand { get; }
        public ICommand NavigateMainMenuAndSerializeCommand { get; }
        #endregion

        public SignUpViewModel(NavigationStore navigationStore)
        {
            NavigateSignInCommand = new NavigateSignInCommand(navigationStore);
            NavigateMainMenuAndSerializeCommand = new NavigateMainMenuAndSerializeCommand(navigationStore);
        }
    }
}
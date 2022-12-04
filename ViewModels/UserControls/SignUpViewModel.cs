using HSchedule.Commands;
using HSchedule.Models.DataBase;
using HSchedule.Stores;
using System.Windows.Input;

namespace HSchedule.ViewModels.UserControls
{
    public delegate void PinDelegate();

    public class SignUpViewModel : ViewModelBase
    {
        #region properties
        private string _personFName;
        public string PersonFName
        {
            get => _personFName;
            set
            {
                _personFName = value;
                PersonSerialization.GetParameters(_personFName, null, null);
            }
        }

        private string _personLName;
        public string PersonLName
        {
            get => _personLName;
            set
            {
                _personLName = value;
                PersonSerialization.GetParameters(null, _personLName, null);
            }
        }

        private string _personPinGeneral;
        public string PersonPinGeneral
        {
            get => _personPinGeneral;
            set
            {
                _personPinGeneral = value;
                PersonSerialization.GetParameters(null, null, _personPinGeneral);
            }
        }

        #region PinCodeParts
        private string _persontPin1;
        public string PersonPin1
        {
            get => _persontPin1;
            set
            {
                _persontPin1 = value;
                CheckPin();
            }
        }
        private string _persontPin2;
        public string PersonPin2
        {
            get => _persontPin2;
            set
            {
                _persontPin2 = value;
                CheckPin();
            }
        }
        private string _persontPin3;
        public string PersonPin3
        {
            get => _persontPin3;
            set
            {
                _persontPin3 = value;
                CheckPin();
            }
        }
        private string _persontPin4;
        public string PersonPin4
        {
            get => _persontPin4;
            set
            {
                _persontPin4 = value;
                CheckPin();
            }
        }
        #endregion
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

        /// <summary>
        /// Merge the pincode into one general
        /// </summary>
        private void CheckPin()
        {
            if (PersonPin1 != null && PersonPin2 != null &&
                PersonPin3 != null && PersonPin4 != null)
            {
                PersonPinGeneral = PersonPin1 + PersonPin2 + PersonPin3 + PersonPin4;
            }
        }
    }
}
using HSchedule.Models;

namespace HSchedule.ViewModels
{
    public class ProfileViewModel : ViewModelBase
    {
		private string _userName;

		public string UserName
        {
			get => _userName;
            set
			{
				if (value != _userName)
				{
                    _userName = value;
                }
			}
		}
	}
}

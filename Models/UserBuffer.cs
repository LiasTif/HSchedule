namespace HSchedule.Models
{
    public class UserBuffer
    {
		private static Person _actualUser;

		public static Person ActualUser
		{
			get => _actualUser;
            set
			{
                _actualUser = value;
            }
		}
	}
}
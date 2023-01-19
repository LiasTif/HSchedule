using HSchedule.Views;

namespace HSchedule.Commands
{
    public class OpenProfileWinCommand : CommandBase
    {
        public override void Execute(object parameter)
        {
            ProfileWindow popupProfile = new ProfileWindow();
            popupProfile.ShowDialog();
        }
    }
}
using System.Windows;

namespace HSchedule.Commands
{
    public class AppExitCommand : CommandBase
    {
        public override void Execute(object parameter)
        {
            Application.Current.Shutdown();
        }
    }
}

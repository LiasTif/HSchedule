using System.Windows;

namespace HSchedule.Commands
{
    /// <summary>
    /// Exit the application
    /// </summary>
    public class AppExitCommand : CommandBase
    {
        public override void Execute(object parameter) => Application.Current.Shutdown();
    }
}

using HSchedule.Models;

namespace HSchedule.Commands
{
    public class RefreshTasksCommand : CommandBase
    {
        public override void Execute(object parameter)
        {
            RefreshTasksScript refreshTasksScript = new RefreshTasksScript();
            refreshTasksScript.Refresh();
        }
    }
}

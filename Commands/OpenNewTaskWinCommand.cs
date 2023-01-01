using HSchedule.Views;

namespace HSchedule.Commands
{
    internal class OpenNewTaskWinCommand : CommandBase
    {
        public override void Execute(object parameter)
        {
            NewTaskWindow popupNewTask = new NewTaskWindow();
            popupNewTask.ShowDialog();
        }
    }
}
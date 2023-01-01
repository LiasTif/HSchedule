using HSchedule.Models;
using HSchedule.Models.DataBase;
using HSchedule.ViewModels;

namespace HSchedule.Commands
{
    public class CreateTaskCommand : CommandBase
    {
        public override void Execute(object parameter)
        {
            TaskSerialization taskSerialization = new TaskSerialization();

            Task task = new Task
            {
                Name = NewTaskViewModel.Name,
                Type = NewTaskViewModel.Type,
                DeadLine = NewTaskViewModel.DeadLine,
                NextPerformer = NewTaskViewModel.NextPerformer,
                Description = NewTaskViewModel.Description
            };
            taskSerialization.CreateNewTask(task);

            RefreshTasksScript refreshTasksScript = new RefreshTasksScript();
            refreshTasksScript.Refresh();
        }
    }
}

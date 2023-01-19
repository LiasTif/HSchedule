using HSchedule.Models;
using HSchedule.Models.DataBase;
using HSchedule.ViewModels;

namespace HSchedule.Commands
{
    public class CreateTaskCommand : CommandBase
    {
        /// <summary>
        /// Write task to dataBase & refresh tasks
        /// </summary>
        /// <param name="parameter"></param>
        public override void Execute(object parameter)
        {
            TaskSerialization taskSerialization = new TaskSerialization();

            Task task = new Task
            {
                Name = TaskViewModel.StaticBuffer.Name,
                Type = TaskViewModel.StaticBuffer.Type,
                DeadLine = TaskViewModel.StaticBuffer.DeadLine,
                NextPerformer = TaskViewModel.StaticBuffer.NextPerformer,
                Description = TaskViewModel.StaticBuffer.Description
            };
            taskSerialization.CreateNewTask(task);

            RefreshTasksScript refreshTasksScript = new RefreshTasksScript();
            refreshTasksScript.Refresh();
        }
    }
}

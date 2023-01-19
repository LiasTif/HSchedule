using HSchedule.ViewModels;
using System.Collections.ObjectModel;

namespace HSchedule.Models.DataBase
{
    public class TasksDeserialization
    {
        // get ObservableCollection of all tasks from Db
        public static ObservableCollection<TaskViewModel> GetTasks()
        {
            using var context = new DbContext();

            if (context.Tasks != null)
            {
                ObservableCollection<TaskViewModel> tasks = new ObservableCollection<TaskViewModel>();
                foreach (Task task in context.Tasks)
                {
                    tasks.Add(new TaskViewModel
                    {
                        Name = task.Name,
                        Id = task.Id,
                        Description = task.Description,
                        IsDone = task.IsDone,
                        DeadLine = task.DeadLine,
                        NextPerformer = task.NextPerformer,
                        Type = task.Type
                    });
                }
                return tasks;
            }
            else return null;
        }
    }
}
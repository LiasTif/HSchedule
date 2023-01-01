using System.Collections.Generic;

namespace HSchedule.Models.DataBase
{
    public class TasksDeserialization
    {
        // get List of all tasks from Db
        public static List<Task> GetTasks()
        {
            using var context = new DbContext();

            if (context.Tasks != null)
            {
                List<Task> tasks = new List<Task>();
                foreach (Task taks in context.Tasks)
                {
                    tasks.Add(taks);
                }
                return tasks;
            }
            else return null;
        }
    }
}
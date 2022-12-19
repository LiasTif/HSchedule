using System.Collections.Generic;

namespace HSchedule.Models.DataBase
{
    public class TasksDeserialization
    {
        public List<Task> GetTasks()
        {
            using var context = new DbContext();

            if (context.Tasks != null)
            {
                int currentId = 1;
                List<Task> tasks = new List<Task>();
                foreach (Task taks in context.Tasks)
                {
                    tasks[currentId] = taks;
                    currentId++;
                }
                return tasks;
            }
            else return null;
        }
    }
}
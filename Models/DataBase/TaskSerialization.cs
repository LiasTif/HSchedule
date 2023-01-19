namespace HSchedule.Models.DataBase
{
    public class TaskSerialization
    {
        /// <summary>
        /// create and add task to db
        /// </summary>
        public void CreateNewTask(Task task)
        {
            using var context = new DbContext();

            context.Tasks.Add(task);

            context.SaveChanges();
        }
    }
}

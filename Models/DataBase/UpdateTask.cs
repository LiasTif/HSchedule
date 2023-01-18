namespace HSchedule.Models.DataBase
{
    public class UpdateTask
    {
        public Task Task { get; set; }

        public UpdateTask(Task task)
        {
            Task = task;
        }

        public void Update()
        {
            using var context = new DbContext();

            if (context.Tasks != null)
            {
                int TaskId = Task.Id;
                if (TaskId <= context.Tasks.Local.Count)
                    ++TaskId;

                if (Task.Name != null)
                    context.Tasks.Find(TaskId).Name = Task.Name;

                if (Task.Type != null)
                    context.Tasks.Find(TaskId).Type = Task.Type;

                if (Task.Description != null)
                    context.Tasks.Find(TaskId).Description = Task.Description;

                if (Task.NextPerformer != null)
                    context.Tasks.Find(TaskId).NextPerformer = Task.NextPerformer;

                if (Task.DeadLine != null)
                    context.Tasks.Find(TaskId).DeadLine = Task.DeadLine;

                context.Tasks.Find(TaskId).IsDone = Task.IsDone;

                context.SaveChanges();
            }
        }
    }
}
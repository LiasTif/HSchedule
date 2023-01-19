//using HSchedule.Models;
//using HSchedule.Models.DataBase;

//namespace HSchedule.Commands
//{
//    public class UpdateTaskCommand : CommandBase
//    {
//        public Task Task { get; set; }

//        public UpdateTaskCommand(Task task)
//        {
//            Task = task;
//        }

//        public override void Execute(object parameter)
//        {
//            using var context = new DbContext();

//            context.Tasks.Find(Task.Id).Name = Task.Name;
//            context.Tasks.Find(Task.Id).Type = Task.Name;
//            context.Tasks.Find(Task.Id).Description = Task.Name;
//            context.Tasks.Find(Task.Id).IsDone = Task.IsDone;
//            context.Tasks.Find(Task.Id).NextPerformer = Task.NextPerformer;
//            context.Tasks.Find(Task.Id).DeadLine = Task.DeadLine;

//            context.SaveChanges();
//        }
//    }
//}
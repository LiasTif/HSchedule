using HSchedule.Models;
using HSchedule.Models.DataBase;
using System;

namespace HSchedule.Commands
{
    public class CreateTaskCommand : CommandBase
    {
        #region properties
        public string Name { get; set; }
        public string Type { get; set; }
        public Person NextPerformer { get; set; }
        public DateTime? DeadLine { get; set; }
        public string Description { get; set; }
        #endregion

        public CreateTaskCommand(string name, string type, DateTime? deadLine,
            Person nextPerformer, string descripton)
        {
            // set income values to properties
            Name = name;
            Type = type;
            DeadLine = deadLine;
            NextPerformer = nextPerformer;
            Description = descripton;
        }

        /// <summary>
        /// Write task to dataBase & refresh tasks
        /// </summary>
        /// <param name="parameter"></param>
        public override void Execute(object parameter)
        {
            TaskSerialization taskSerialization = new TaskSerialization();

            Task task = new Task
            {
                Name = this.Name,
                Type = this.Type,
                DeadLine = this.DeadLine,
                NextPerformer = this.NextPerformer,
                Description = this.Description
            };
            taskSerialization.CreateNewTask(task);

            RefreshTasksScript refreshTasksScript = new RefreshTasksScript();
            refreshTasksScript.Refresh();
        }
    }
}

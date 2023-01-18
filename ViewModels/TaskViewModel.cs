using HSchedule.Commands;
using HSchedule.Models;
using HSchedule.Models.DataBase;
using System;
using System.Windows.Input;

namespace HSchedule.ViewModels
{
    public class TaskViewModel : ViewModelBase
    {
        public ICommand CreateTaskCommand { get; }

        public TaskViewModel()
        {
            CreateTaskCommand = new CreateTaskCommand();
        }

        private Task GetTaskParams()
        {
            Task task = new Task
            {
                Id = this.Id,
                Name = this.Name,
                Type = this.Type,
                NextPerformer = this.NextPerformer,
                DeadLine = this.DeadLine,
                IsDone = this.IsDone,
                Description = this.Description
            };
            StaticBuffer = task;

            return task;
        }

        #region properties
        public static Task StaticBuffer { get; set; }

        private int _id;
        public int Id
        {
            get => _id;
            set
            {
                _id = value;
                UpdateTask updateTask = new UpdateTask(GetTaskParams());
                updateTask.Update();
            }
        }

        private string _name;
        public string Name
        {
            get => _name;
            set
            {
                _name = value;
                UpdateTask updateTask = new UpdateTask(GetTaskParams());
                updateTask.Update();
            }
        }

        private string _type;
        public string Type
        {
            get => _type;
            set
            {
                _type = value;
                UpdateTask updateTask = new UpdateTask(GetTaskParams());
                updateTask.Update();
            }
        }

        private Person _nextPerformer;
        public Person NextPerformer
        {
            get => _nextPerformer;
            set
            {
                _nextPerformer = value;
                UpdateTask updateTask = new UpdateTask(GetTaskParams());
                updateTask.Update();
            }
        }

        private DateTime? _deadLine;
        public DateTime? DeadLine
        {
            get => _deadLine;
            set
            {
                _deadLine = value;
                UpdateTask updateTask = new UpdateTask(GetTaskParams());
                updateTask.Update();
            }
        }

        private bool _isDone;
        public bool IsDone
        {
            get => _isDone;
            set
            {
                _isDone = value;
                UpdateTask updateTask = new UpdateTask(GetTaskParams());
                updateTask.Update();
                OnPropertyChanged("IsDone");
            }
        }

        private string _description;
        public string Description
        {
            get => _description;
            set
            {
                _description = value;
                UpdateTask updateTask = new UpdateTask(GetTaskParams());
                updateTask.Update();
            }
        }
        #endregion
    }
}
using HSchedule.Commands;
using HSchedule.Models;
using HSchedule.Models.DataBase;
using HSchedule.Stores;
using System;
using System.Collections.Generic;
using System.Windows.Input;

namespace HSchedule.ViewModels.UserControls
{
    public class MainMenuViewModel : ViewModelBase
    {
        #region commands
        public ICommand AppExitCommand { get; }
        public ICommand OpenNewTaskWinCommand { get; }
        public ICommand OpenProfileWinCommand { get; }
        public ICommand RefreshTasksCommand { get; }
        #endregion

        #region properties
        private static List<Task> _tasks = TasksDeserialization.GetTasks();

        public static List<Task> Tasks
        {
            get => _tasks;
            set
            {
                _tasks = value;
                OnTasksChanged(EventArgs.Empty);
            }
        }
        #endregion

        public MainMenuViewModel(NavigationStore navigationStore)
        {
            AppExitCommand = new AppExitCommand();
            OpenNewTaskWinCommand = new OpenNewTaskWinCommand();
            OpenProfileWinCommand = new OpenProfileWinCommand();
            RefreshTasksCommand = new RefreshTasksCommand();

            TasksChanged += (sender, e) => { return; };
        }

        // Declare a static event representing changes to static property
        public static event EventHandler TasksChanged;

        // Raise the change event through this static method
        protected static void OnTasksChanged(EventArgs e)
        {
            TasksChanged?.Invoke(null, e);
        }
    }
}

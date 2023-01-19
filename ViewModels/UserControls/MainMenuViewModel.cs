using HSchedule.Commands;
using HSchedule.Models;
using HSchedule.Models.DataBase;
using HSchedule.Stores;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
        private static ObservableCollection<TaskViewModel> _tasks = TasksDeserialization.GetTasks();
        public static ObservableCollection<TaskViewModel> Tasks
        {
            get => _tasks;
            set
            {
                if (value != _tasks)
                {
                    _tasks = value;
                    OnTasksChanged(EventArgs.Empty);
                }
            }
        }

        private TaskViewModel _selectedTask;
        public TaskViewModel SelectedTask
        {
            get => _selectedTask;
            set
            {
                if (value != _selectedTask)
                {
                    _selectedTask = value;
                }
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

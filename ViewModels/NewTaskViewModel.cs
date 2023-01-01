using HSchedule.Commands;
using HSchedule.Models;
using System;
using System.Windows;
using System.Windows.Input;

namespace HSchedule.ViewModels
{
    public class NewTaskViewModel : DependencyObject
    {
        public ICommand CreateTaskCommand { get; }

        public NewTaskViewModel()
        {
            CreateTaskCommand = new CreateTaskCommand();
        }

        #region properties
        public static string Name { get; set; }
        public static string Type { get; set; }
        public static DateTime? DeadLine { get; set; }
        public static Person NextPerformer { get; set; }
        public static string Description { get; set; }
        #endregion
    }
}
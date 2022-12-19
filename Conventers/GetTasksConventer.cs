﻿using HSchedule.Models.DataBase;
using System;
using System.Globalization;
using System.Windows.Data;

namespace HSchedule.Conventers
{
    public class GetTasksConventer : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            TasksDeserialization tasksDeserialization = new TasksDeserialization();
            return tasksDeserialization.GetTasks();
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotSupportedException();
        }
    }
}

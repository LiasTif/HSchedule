using HSchedule.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Data;

namespace HSchedule.Conventers
{
    public class GetTasksConventer : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            List<Task> tasks = new List<Task>
            {
                new Task { Id = 1, Title = "Убрать кухню", IsDone = true},
                new Task { Id = 2, Title = "Убрать ванную"},
                new Task { Id = 3, Title = "Убрать прихожую"}
            };
            return tasks;
    }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotSupportedException();
        }
    }
}

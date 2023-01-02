using HSchedule.Models;
using System;
using System.Globalization;
using System.Windows.Data;

namespace HSchedule.Conventers
{
    public class PersonNameConventer : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            Person person = (Person)value;
            return (person.FName + " " + person.LName).ToString();
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotSupportedException();
        }
    }
}

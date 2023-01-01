using System;
using System.Globalization;
using System.Linq;
using System.Windows.Data;

namespace HSchedule.Conventers
{
    internal class NewTaskDataConventer : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            if (values.Count() >= 3) 
            {
                if (( !(bool)values[0] && !(bool)values[1] ) || string.IsNullOrEmpty(values[2].ToString()) )
                {
                    return false;
                }
                else return true;
            }
            else
                return false;
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}

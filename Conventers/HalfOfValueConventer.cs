using System;
using System.Globalization;
using System.Windows.Data;

namespace HSchedule.Conventers
{
    public class HalfOfValueConventer : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is double)
            {
                return (double)value * 0.5;
            }
            return null;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotSupportedException();
        }
    }
}

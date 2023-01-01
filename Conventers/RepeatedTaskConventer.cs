using System;
using System.Globalization;
using System.Windows.Data;

namespace HSchedule.Conventers
{
    internal class RepeatedTaskConventer : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value != null)
            {
                if (value.ToString() == "repeated")
                {
                    return true;
                }
                else if (value.ToString() == "oneTime")
                {
                    return false;
                }
            }
            return false;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value != null)
            {
                if ((bool)value)
                {
                    return "repeated";
                }
                else
                {
                    return "oneTime";
                }
            }
            return false;
        }
    }
}

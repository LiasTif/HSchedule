using System;
using System.Globalization;
using System.Windows.Data;

namespace HSchedule.Conventers
{
    public class OneTimeTaskConventer : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value != null)
            {
                if (value.ToString() == "oneTime")
                {
                    return true;
                }
                else if (value.ToString() == "repeated")
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
                    return "oneTime";
                }
                else
                {
                    return "repeated";
                }
            }
            return false;
        }
    }
}

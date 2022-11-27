using System;
using System.Globalization;
using System.Linq;
using System.Windows.Data;

namespace HSchedule.Conventers
{
    public class RegistrationDataConventer : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            if (values.Count() >= 3)
            {
                if (string.IsNullOrEmpty(values[0].ToString()) || string.IsNullOrEmpty(values[1].ToString()) ||
                    string.IsNullOrEmpty(values[2].ToString()))
                    return false;
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

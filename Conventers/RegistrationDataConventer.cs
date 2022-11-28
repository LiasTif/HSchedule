using System;
using System.Globalization;
using System.Linq;
using System.Windows.Data;

namespace HSchedule.Conventers
{
    /// <summary>
    /// collects data from TextBoxes and returns True(Button enabled) if the fields are filled
    /// </summary>
    public class RegistrationDataConventer : IMultiValueConverter
    {
        /// <summary>
        /// collect values from 3 TextBoxes and check if they are filled to activate the button
        /// </summary>
        /// <param name="values"></param>
        /// <param name="targetType"></param>
        /// <param name="parameter"></param>
        /// <param name="culture"></param>
        /// <returns>visibility for buttom(bool)</returns>
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

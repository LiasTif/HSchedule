using HSchedule.Models.DataBase;
using System;
using System.Globalization;
using System.Windows.Data;

namespace HSchedule.Conventers
{
    /// <summary>
    /// get information from TextBox and put in into Person
    /// </summary>
    public class GetTextInfoConventer : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            PersonSerialization personSerialization = new PersonSerialization();
            string fname = "", lname = "", pin = "";

            if (values[2] != null || values[3] != null ||
                values[4] != null || values[5] != null)
                pin += values[2].ToString() + values[3].ToString() + values[4].ToString() + values[5].ToString();

            bool Parsed = Int32.TryParse(pin, out int actualPin);

            if (values[0] is String firstName)
                fname = firstName.ToString();
            if (values[1] is String lastName)
                lname = lastName.ToString();

            if (Parsed)
                personSerialization.CreateNewPerson(fname, lname, actualPin);

            return null;
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotSupportedException();
        }
    }
}
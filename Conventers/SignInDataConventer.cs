using HSchedule.Models;
using HSchedule.Models.DataBase;
using System;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Data;

namespace HSchedule.Conventers
{
    public class SignInDataConventer : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            if (values.Count() >= 6)
            {
                using var context = new DbContext();

                // check, is vulues are not empty
                if (!string.IsNullOrEmpty(values[0].ToString()) && !string.IsNullOrEmpty(values[1].ToString()) &&
                    !string.IsNullOrEmpty(values[2].ToString()) && !string.IsNullOrEmpty(values[3].ToString()) &&
                    !string.IsNullOrEmpty(values[4].ToString()) && !string.IsNullOrEmpty(values[5].ToString()))
                {
                    ComparePersons comparePersons = new ComparePersons();

                    // create general pincode
                    string pin = values[2].ToString() + values[3].ToString() + values[4].ToString() + values[5].ToString();

                    // create person based on values for comparse
                    Person person = new Person
                    {
                        FName = values[0].ToString(),
                        LName = values[1].ToString(),
                        PinCode = Int32.Parse(pin)
                    };

                    // compare present person with persons in DataBase
                    for (int i = 1; i < context.Persons.Count(); i++)
                    {
                        if (comparePersons.Compare(person, context.Persons.Find(i)))
                            return true;
                    }
                }
            }
            return false;
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotSupportedException();
        }
    }
}

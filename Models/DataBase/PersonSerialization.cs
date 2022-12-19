using System;

namespace HSchedule.Models.DataBase
{
    public class PersonSerialization
    {
        #region properties
        public static string FirstName { get; set; }
        public static string LastName { get; set; }
        public static string Pin { get; set; }
        #endregion

        /// <summary>
        /// Create and add to Db new Person
        /// </summary>
        /// <param name="fname">Person firstName</param>
        /// <param name="lname">Person lastName</param>
        /// <param name="pin">Person pin-code</param>
        public void CreateNewPerson()
        {
            using var context = new DbContext();

            Person person = new Person { FName = FirstName, LName = LastName, PinCode = Int32.Parse(Pin) };
            context.Persons.Add(person);

            context.SaveChanges();
        }

        /// <summary>
        /// Get Person parameters and set its to buffers
        /// </summary>
        public static void GetParameters(string fName, string lName, string pin)
        {
            if (fName != null)
                FirstName = fName;
            if (lName != null)
                LastName = lName;
            if (pin != null)
                Pin = pin;
        }
    }
}
using System;

namespace HSchedule.Models.DataBase
{
    public class PersonSerialization
    {
        /// <summary>
        /// Create and add to Db new Person
        /// </summary>
        /// <param name="fname">Person firstName</param>
        /// <param name="lname">Person lastName</param>
        /// <param name="pin">Person pin-code</param>
        public void CreateNewPerson(string fname, string lname, string pin)
        {
            using var context = new DbContext();

            Person person = new Person { FName = fname, LName = lname, Password = Int32.Parse(pin) };
            context.Persons.Add(person);

            context.SaveChanges();
        }
    }
}
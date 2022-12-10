namespace HSchedule.Models.DataBase
{
    /// <summary>
    /// provides a function for comparing two Person entities
    /// </summary>
    public class ComparePersons
    {
        /// <summary>
        /// compare two peoples
        /// </summary>
        /// <param name="person1"></param>
        /// <param name="person2"></param>
        /// <returns>returns true whether the personas are the same</returns>
        public bool Compare(Person person1, Person person2)
        {
            if (person1.FName.Equals(person2.FName) && person1.LName.Equals(person2.LName) &&
                person1.PinCode.Equals(person2.PinCode))
            {
                return true;
            }

            return false;
        }
    }
}

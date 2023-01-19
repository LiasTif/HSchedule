using System.Data.Entity;

namespace HSchedule.Models.DataBase
{
    public class DbContext : System.Data.Entity.DbContext
    {
        public DbContext() : base("DbHSchedule")
        {
        }

        public DbSet<Task> Tasks { get; set; }
        public DbSet<Person> Persons { get; set; }
    }
}

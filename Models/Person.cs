using System.ComponentModel.DataAnnotations;

namespace HSchedule.Models
{
    public class Person
    {
        [Required]
        [Key]
        public int Id { get; set; }
        [Required]
        public string FName { get; set; }
        [Required]
        public string LName { get; set; }
        [Required]
        public int Password { get; set; }
    }
}

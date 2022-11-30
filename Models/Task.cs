using System;
using System.ComponentModel.DataAnnotations;

namespace HSchedule.Models
{
    public class Task
    {
        [Required]
        [Key]
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        public Person LastPerformer { get; set; }
        public DateTime Date { get; set; }
        public bool IsDone { get; set; }
    }
}
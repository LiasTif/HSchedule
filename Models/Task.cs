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
        [Required]
        public string Type { get; set; }
        public Person NextPerformer { get; set; }
        public DateTime? DeadLine { get; set; }
        public bool IsDone { get; set; }
        public string Description { get; set; }
    }
}
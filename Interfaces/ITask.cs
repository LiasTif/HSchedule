using HSchedule.Models;
using System;

namespace HSchedule.Interfaces
{
    public interface ITask
    {
        string Name { get; set; }
        string Type { get; set; }
        string Description { get; set; }
        Person NextPerformer { get; set; }
        DateTime? DeadLine { get; set; }
    }
}
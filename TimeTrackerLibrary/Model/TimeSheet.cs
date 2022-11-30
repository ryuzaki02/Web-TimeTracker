using System;
using System.ComponentModel.DataAnnotations;

namespace TimeTrackerLibrary.Model
{
	public class TimeSheet
	{
        [Required]
        public User? User { get; set; }
        [Key]
        public int TimesheetId { get; set; }
        [Required]
        public DateOnly WorkDate { get; set; }
        [Required]
        public TimeOnly BeginTime { get; set; }
        [Required]
        public TimeOnly Duration { get; }
        [Required]
        public double Amount { get; }
        [Required]
        public string? Description { get; set; }
        [Required]
        public string? Activity { get; set; }
    }
}


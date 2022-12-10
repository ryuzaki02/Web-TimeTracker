using System;
using System.ComponentModel.DataAnnotations;

namespace TimeTrackerLibrary.Model
{
	public class TimeSheet
	{
        [Required]
        public int UserId { get; set; }
        [Key]
        public int TimesheetId { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime WorkDate { get; set; }
        [Required]
        [DataType(DataType.Time)]
        public DateTime BeginTime { get; set; }
        [Required]
        public DateTime Duration { get; }
        [Required]
        public double Amount { get; }
        [Required]
        public string? Description { get; set; }
        [Required]
        public string? Activity { get; set; }
    }
}


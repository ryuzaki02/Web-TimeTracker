using System;
using System.ComponentModel.DataAnnotations;

namespace TimeTrackerLibrary.Model
{
	public class User
	{
        [Key]
        public int UserId { get; set; }
        [Required]
        public string? UserName { get; set; }
        [Required]
        public int Rate { get; set; }
        public List<TimeSheet>? TimeSheets { get; set; }
    }
}


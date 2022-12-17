using System;
using Microsoft.EntityFrameworkCore;
using TimeTrackerLibrary.Data;
using TimeTrackerLibrary.Model;

namespace TimeTrackerLibrary.ViewModel
{
	public class TimeSheetViewModel
	{
        private TimeTrackerDbContext _context;
        public int _userId;

        public TimeSheetViewModel(TimeTrackerDbContext context, int userId)
        {
            _context = context;
            _userId = userId;
        }

        public User? GetUser(int id)
        {
            return _context.Users.Where(b => b.UserId == id).FirstOrDefault() ?? null;
        }

        public async Task<List<TimeSheet>> GetTimeSheets()
        {
            List<TimeSheet> temp = await _context.TimeSheets.ToListAsync();
            return FilterUserTimeSheets(temp);
        }

        public List<TimeSheet> FilterUserTimeSheets(List<TimeSheet> allTimesheets)
        {
            List<TimeSheet> timeSheets = new List<TimeSheet>();
            foreach (TimeSheet timeSheet in allTimesheets)
            {
                if (timeSheet.UserId == _userId)
                {
                    timeSheets.Add(timeSheet);
                }
            }
            return timeSheets;
        }
    }
}


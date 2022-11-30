using System;
using TimeTrackerLibrary.Model;
using TimeTrackerLibrary.Data;
using Microsoft.EntityFrameworkCore;

namespace TimeTrackerLibrary.ViewModel
{
	public class UserViewModel
	{
        private TimeTrackerDbContext _context;

        public UserViewModel(TimeTrackerDbContext context)
        {
            _context = context;
        }

        public async Task<List<User>> GetUsers() => await _context.Users.ToListAsync();
    }
}


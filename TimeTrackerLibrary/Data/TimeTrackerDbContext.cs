using System;
using Microsoft.EntityFrameworkCore;
using TimeTrackerLibrary.Model;

namespace TimeTrackerLibrary.Data
{
	public class TimeTrackerDbContext : DbContext
	{
        public DbSet<User> Users => Set<User>();
        public DbSet<TimeSheet> TimeSheets => Set<TimeSheet>();

        public string DbPath { get; }

        public TimeTrackerDbContext()
        {
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            DbPath = System.IO.Path.Join(path, "timetracker.db");
        }

        // The following configures EF to create a Sqlite database file in the
        // special "local" folder for your platform.
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite($"Data Source={DbPath}");
    }
}


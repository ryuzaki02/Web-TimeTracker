using System;
using TimeTrackerLibrary.Data;
using TimeTrackerLibrary.Model;
using TimeTrackerLibrary.ViewModel;

namespace TimeTrackerTests
{
	[TestClass]
	public class TimeSheetTest
	{
        private TimeSheetViewModel timesheetViewModel;
        public TimeSheetTest()
		{
            TimeTrackerDbContext dbContext = new TimeTrackerDbContext();
            timesheetViewModel = new TimeSheetViewModel(dbContext, 1);
        }

        [TestMethod]
        public async Task Check_For_Empty_TimeSheetList_TestAsync()
        {
            List<TimeSheet> timeSheets = await timesheetViewModel.GetTimeSheets();
            Assert.IsTrue(timeSheets.Count == 0);
        }

        [TestMethod]
        public void Check_For_Empty_User_Test()
        {
            User? user = timesheetViewModel.GetUser(-1);
            Assert.IsTrue(user == null);
        }

        [TestMethod]
        public void Check_For_User_Timesheet_From_List_Of_Timesheets()
        {
            List<TimeSheet> timeSheets = timesheetViewModel.FilterUserTimeSheets(new List<TimeSheet>());
            Assert.IsTrue(timeSheets == null);
        }
    }
}


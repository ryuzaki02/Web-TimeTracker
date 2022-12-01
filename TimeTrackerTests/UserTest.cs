using System;
using TimeTrackerLibrary.ViewModel;
using TimeTrackerLibrary.Data;
using TimeTrackerLibrary.Model;

namespace TimeTrackerTests
{
    [TestClass]
    public class UserTest
	{
		private UserViewModel userViewModel;
		public UserTest()
		{
			TimeTrackerDbContext dbContext = new TimeTrackerDbContext();
			userViewModel = new UserViewModel(dbContext);
		}

		[TestMethod]
		public async Task Check_For_Empty_Users_TestAsync()
		{
			List<User> users = await userViewModel.GetUsers();
			Assert.IsTrue(users.Count == 0);
		}
	}
}


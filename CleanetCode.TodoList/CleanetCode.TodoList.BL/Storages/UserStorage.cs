using CleanetCode.TodoList.BL.Models;

namespace CleanetCode.TodoList.BL.Storages
{
	public static class UserStorage
	{
		private static readonly Dictionary<string, User> _users = new();

		public static User? Get(string email)
		{
			_users.TryGetValue(email, out User? user);
			return user; 
		}

		public static bool Create(User user)
		{
			return _users.TryAdd(user.Email, user);
		}
	}
}

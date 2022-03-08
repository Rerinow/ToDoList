using CleanetCode.TodoList.BL.Models;
using System.Text.Json;

namespace CleanetCode.TodoList.BL.Storages
{
	public static class UserStorage
	{
		private static Dictionary<string, User> _users = new();

		public static User? Get(string email)
		{
			InitilizeUsers();
			_users.TryGetValue(email, out User? user);
			return user;
		}

		public static bool Create(User user)
		{
			InitilizeUsers();
			if (!_users.TryAdd(user.Email, user))
            {
				return false;
            }
			File.WriteAllText(@".\users.json", JsonSerializer.Serialize(_users));
			return true;
		}
		private static void InitilizeUsers()
        {
			if (_users.Count == 0 && File.Exists(@".\users.json"))
			{
				_users = JsonSerializer.Deserialize<Dictionary<string, User>>(File.ReadAllText(@".\users.json"));
			}
		}
	}
}

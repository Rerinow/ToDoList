using CleanetCode.TodoList.BL;
using CleanetCode.TodoList.BL.Models;
using CleanetCode.TodoList.BL.Storages;

namespace CleanetCode.TodoList.BL.Operations
{
	public class LoginUserOperation : IOperation
	{
		public string Name => "Залогиниться в системе";

		public void Execute()
		{
			Console.Write("Введите ваш email:");
			string? email = Console.ReadLine();
			User? user = UserStorage.Get(email);

			if (user == null)
			{
				UserSession.CurrentUser = user;
			}
		}
	}
}

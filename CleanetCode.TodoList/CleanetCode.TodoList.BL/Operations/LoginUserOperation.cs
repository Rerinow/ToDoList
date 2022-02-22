using CleanetCode.TodoList.BL;
using CleanetCode.TodoList.BL.Models;
using CleanetCode.TodoList.BL.Storages;

namespace CleanetCode.TodoList.BL.Operations
{
	public class LoginUserOperation : IOperation
	{
		public string Name => "Залогиниться в системе";
		public string Description => "Залогинтесь используя ваш email";
		public string OperationType => "ActionWithValue";
		public string OperationValue { get; set; }
		public string OperationStatus { get; private set; } = "Операция не выполнена";


		public void Execute()
		{
			string? email = OperationValue;
			User? user = UserStorage.Get(email);

			if (user == null)
			{
				throw new KeyNotFoundException($"Пользователь не найден. {OperationStatus}");
				//UserSession.CurrentUser = user;
			}
			OperationStatus = "Операция успешно выполнена";
		}
	}
}

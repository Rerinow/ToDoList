using CleanetCode.TodoList.BL.Models;
using CleanetCode.TodoList.BL.Storages;

namespace CleanetCode.TodoList.BL.Operations
{
	public class CreateNewUserOperation : IOperation
	{
		public string Name => "Создать нового пользователя";
		public string Description => "Создайте пользователя используя email";
		public string OperationValue { get; set; }
		public string OperationType => "ActionWithValue";
		public string OperationStatus { get; private set; } = "Операция не выполнена";
		public void Execute()
		{
			string? email = OperationValue;

			User newUser = new User
			{
				Email = email,
			};

			bool userCreated = UserStorage.Create(newUser);
			if (!userCreated)
			{
				//custom exception
			}
			OperationStatus = "Операция успешно выполнена";
		}
	}
}


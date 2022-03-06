using CleanetCode.TodoList.BL;
using CleanetCode.TodoList.BL.CustomExceptions;
using CleanetCode.TodoList.BL.DTO;
using CleanetCode.TodoList.BL.Models;
using CleanetCode.TodoList.BL.Storages;

namespace CleanetCode.TodoList.BL.Operations
{
	public class LoginUserOperation 
	{
		public void Execute(UserDTO userDTO)
		{
			string? email = userDTO.Email;
			if (String.IsNullOrEmpty(email))
			{
				throw new NullOrEmptyFieldException("Ошибка: Заполните Email!");
			}
			User? user = UserStorage.Get(email);

			if (user == null)
			{
				throw new KeyNotFoundException($"Ошибка: Пользователь не найден.");
			}
			UserSession.CurrentUser = user;
		}
	}
}

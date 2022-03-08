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
				throw new ArgumentNullException("Error: Please provide your email");
			}
			User? user = UserStorage.Get(email);

			if (user == null)
			{
				throw new KeyNotFoundException($"Error: User not found");
			}
			UserSession.CurrentUser = user;
		}
	}
}

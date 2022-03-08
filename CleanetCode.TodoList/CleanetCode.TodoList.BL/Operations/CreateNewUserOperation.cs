using CleanetCode.TodoList.BL.CustomExceptions;
using CleanetCode.TodoList.BL.DTO;
using CleanetCode.TodoList.BL.Models;
using CleanetCode.TodoList.BL.Storages;

namespace CleanetCode.TodoList.BL.Operations
{
	public class CreateNewUserOperation 
	{
		public void Execute(UserDTO userDTO)
		{
			string? email = userDTO.Email;

            if (String.IsNullOrEmpty(email))
            {
				throw new ArgumentNullException("Error: Please fill your email");
            }

			User newUser = new User
			{
				Email = email,
			};

			bool userCreated = UserStorage.Create(newUser);
			if (!userCreated)
			{
				throw new AlreadyExistsObjectException($"Error: This {email} already registered!");
			}
			UserSession.CurrentUser = newUser;
		}
	}
}


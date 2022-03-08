using CleanetCode.TodoList.BL.DTO;
using CleanetCode.TodoList.BL.Operations;
using CleanetCode.TodoList.CLI.Infrastructure;

namespace CleanetCode.TodoList.CLI.Forms
{
    public class LoginUserForm : IForm, IUserForm
    {
        public string Name => "Login by email";

        public void Execute()
        {
            InputMessage.WriteLine("Please provide your email:");
            string? email = Console.ReadLine();
            var userDTO = new UserDTO()
            {
                Email = email,
            };
            var loginUserOperation = new LoginUserOperation();
            loginUserOperation.Execute(userDTO);
            InfoMessage.WriteLine("User was authorized.");
        }
    }
}

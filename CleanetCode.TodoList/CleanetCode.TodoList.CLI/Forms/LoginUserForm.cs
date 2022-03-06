using CleanetCode.TodoList.BL.DTO;
using CleanetCode.TodoList.BL.Operations;
using CleanetCode.TodoList.CLI.Infrastructure;

namespace CleanetCode.TodoList.CLI.Forms
{
    public class LoginUserForm : IForm
    {
        public string Name => "Залогинится используя Email";

        public void Execute()
        {
            InputConsole.WriteLine("Введите Email:");
            string? email = Console.ReadLine();
            var userDTO = new UserDTO()
            {
                Email = email,
            };
            var loginUserOperation = new LoginUserOperation();
            loginUserOperation.Execute(userDTO);
            InfoConsole.WriteLine("Пользователь успешно авторизован.");
        }
    }
}

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
            InputMessage.WriteLine("Введите Email:");
            string? email = Console.ReadLine();
            var userDTO = new UserDTO()
            {
                Email = email,
            };
            var loginUserOperation = new LoginUserOperation();
            loginUserOperation.Execute(userDTO);
            InfoMessage.WriteLine("Пользователь успешно авторизован.");
        }
    }
}

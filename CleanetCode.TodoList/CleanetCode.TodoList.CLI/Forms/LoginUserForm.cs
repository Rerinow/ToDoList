using CleanetCode.TodoList.BL.DTO;
using CleanetCode.TodoList.BL.Operations;

namespace CleanetCode.TodoList.CLI.Forms
{
    public class LoginUserForm : IForm
    {
        public string Name => "Залогинится используя Email";

        public void Execute()
        {
            Console.WriteLine("Введите Email:");
            string? email = Console.ReadLine();
            var userDTO = new UserDTO()
            {
                Email = email,
            };
            var loginUserOperation = new LoginUserOperation();
            loginUserOperation.Execute(userDTO);
            Console.WriteLine("Пользователь успешно авторизован.");
        }
    }
}

using CleanetCode.TodoList.BL.DTO;
using CleanetCode.TodoList.BL.Operations;
using CleanetCode.TodoList.CLI.Infrastructure;

namespace CleanetCode.TodoList.CLI.Forms
{
    public class CreateNewUserForm : IForm
    {
        public string Name => "Регистрация пользователя";
        public void Execute()
        {
            InputConsole.WriteLine("Введите Email:");
            string? email = Console.ReadLine();
            var userDTO = new UserDTO()
            {
                Email = email,
            };
            var createNewUserOperation = new CreateNewUserOperation();
            createNewUserOperation.Execute(userDTO);
            InfoConsole.WriteLine("Пользователь успешно зарегистрирован.");
        }
    }
}

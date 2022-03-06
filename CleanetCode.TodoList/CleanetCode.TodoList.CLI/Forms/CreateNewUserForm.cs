using CleanetCode.TodoList.BL.DTO;
using CleanetCode.TodoList.BL.Operations;

namespace CleanetCode.TodoList.CLI.Forms
{
    public class CreateNewUserForm : IForm
    {
        public string Name => "Регистрация пользователя";
        public void Execute()
        {
            Console.WriteLine("Введите Email:");
            string? email = Console.ReadLine();
            var userDTO = new UserDTO()
            {
                Email = email,
            };
            var createNewUserOperation = new CreateNewUserOperation();
            createNewUserOperation.Execute(userDTO);
            Console.WriteLine("Пользователь успешно зарегистрирован.");
        }
    }
}

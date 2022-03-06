using CleanetCode.TodoList.BL.DTO;
using CleanetCode.TodoList.BL.Operations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

using CleanetCode.TodoList.BL.DTO;
using CleanetCode.TodoList.BL.Operations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanetCode.TodoList.CLI.Forms
{
    public class CreateNewTaskForm : IForm
    {
        public string Name => "Создание новой задачи";

        public void Execute()
        {
            var taskDTO = new TaskDTO();
            Console.WriteLine("Введите название задачи:");
            taskDTO.Name = Console.ReadLine();
            Console.WriteLine("Введите описание задачи:");
            taskDTO.Description = Console.ReadLine();
            var createNewTaskOperation = new CreateNewTaskOperation();
            createNewTaskOperation.Execute(taskDTO);
            Console.WriteLine("Задача успешно создана.");
        }
    }
}

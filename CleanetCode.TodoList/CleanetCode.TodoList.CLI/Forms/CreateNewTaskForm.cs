using CleanetCode.TodoList.BL.DTO;
using CleanetCode.TodoList.BL.Operations;
using CleanetCode.TodoList.CLI.Infrastructure;

namespace CleanetCode.TodoList.CLI.Forms
{
    public class CreateNewTaskForm : IForm
    {
        public string Name => "Создание новой задачи";

        public void Execute()
        {
            var taskDTO = new TaskDTO();
            InputConsole.WriteLine("Введите название задачи:");
            taskDTO.Name = Console.ReadLine();
            InputConsole.WriteLine("Введите описание задачи:");
            taskDTO.Description = Console.ReadLine();
            var createNewTaskOperation = new CreateNewTaskOperation();
            createNewTaskOperation.Execute(taskDTO);
            InfoConsole.WriteLine("Задача успешно создана.");
        }
    }
}

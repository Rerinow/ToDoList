using CleanetCode.TodoList.BL.DTO;
using CleanetCode.TodoList.BL.Operations;
using CleanetCode.TodoList.CLI.Infrastructure;

namespace CleanetCode.TodoList.CLI.Forms
{
    public class UpdateTaskForm : IForm
    {
        public string Name => "Обновить задачу";

        public void Execute()
        {
            var taskDTO = new TaskDTO();
            InputConsole.WriteLine("Введите номер задачи:");
            taskDTO.Id = Console.ReadLine();
            InputConsole.WriteLine("Введите название задачи:");
            taskDTO.Name = Console.ReadLine();
            InputConsole.WriteLine("Введите описание задачи:");
            taskDTO.Description = Console.ReadLine();
            var updateTaskOperation = new UpdateTaskOperation();
            updateTaskOperation.Execute(taskDTO);
            InfoConsole.WriteLine("Задача успешно обновлена.");
        }
    }
}

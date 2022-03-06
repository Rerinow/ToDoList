using CleanetCode.TodoList.BL.DTO;
using CleanetCode.TodoList.BL.Operations;

namespace CleanetCode.TodoList.CLI.Forms
{
    public class UpdateTaskForm : IForm
    {
        public string Name => "Обновить задачу";

        public void Execute()
        {
            var taskDTO = new TaskDTO();
            Console.WriteLine("Введите номер задачи:");
            taskDTO.Id = Console.ReadLine();
            Console.WriteLine("Введите название задачи:");
            taskDTO.Name = Console.ReadLine();
            Console.WriteLine("Введите описание задачи:");
            taskDTO.Description = Console.ReadLine();
            var updateTaskOperation = new UpdateTaskOperation();
            updateTaskOperation.Execute(taskDTO);
            Console.WriteLine("Задача успешно обновлена.");
        }
    }
}

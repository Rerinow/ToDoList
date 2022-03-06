using CleanetCode.TodoList.BL.DTO;
using CleanetCode.TodoList.BL.Operations;
using CleanetCode.TodoList.CLI.Infrastructure;

namespace CleanetCode.TodoList.CLI.Forms
{
    public class CompleteTaskForm : IForm
    {
        public string Name => "Завершить задачу";

        public void Execute()
        {
            TaskDTO taskDTO = new TaskDTO();
            InputConsole.WriteLine("Введите номер задачи:");
            taskDTO.Id = Console.ReadLine();
            new CompleteTaskOperation().Execute(taskDTO);
            InfoConsole.WriteLine("Задача завершена.");
        }
    }
}

using CleanetCode.TodoList.BL.DTO;
using CleanetCode.TodoList.BL.Operations;

namespace CleanetCode.TodoList.CLI.Forms
{
    public class CompleteTaskForm : IForm
    {
        public string Name => "Завершить задачу";

        public void Execute()
        {
            TaskDTO taskDTO = new TaskDTO();
            Console.WriteLine("Введите номер задачи:");
            taskDTO.Id = Console.ReadLine();
            new CompleteTaskOperation().Execute(taskDTO);
            Console.WriteLine("Задача завершена.");
        }
    }
}

using CleanetCode.TodoList.BL.DTO;
using CleanetCode.TodoList.BL.Operations;
using CleanetCode.TodoList.CLI.Infrastructure;

namespace CleanetCode.TodoList.CLI.Forms
{
    public class CompleteTaskForm : IForm, ITaskForm
    {
        public string Name => "Завершить задачу";

        public void Execute()
        {
            TaskDTO taskDTO = new TaskDTO();
            InputMessage.WriteLine("Введите номер задачи:");
            taskDTO.Id = Console.ReadLine();
            new CompleteTaskOperation().Execute(taskDTO);
            InfoMessage.WriteLine("Задача завершена.");
        }
    }
}

using CleanetCode.TodoList.BL.DTO;
using CleanetCode.TodoList.BL.Operations;

namespace CleanetCode.TodoList.CLI.Forms
{
    public class DeleteTaskForm : IForm
    {
        public string Name => "Удаление задачи";

        public void Execute()
        {
            TaskDTO taskDTO = new TaskDTO();
            Console.WriteLine("Введите номер задачи:");
            taskDTO.Id = Console.ReadLine();
            new DeleteTaskOperation().Execute(taskDTO);
            Console.WriteLine("Задача завершена.");
        }
    }
}

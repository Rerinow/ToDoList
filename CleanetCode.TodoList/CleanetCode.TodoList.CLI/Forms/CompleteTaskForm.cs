using CleanetCode.TodoList.BL.DTO;
using CleanetCode.TodoList.BL.Operations;
using CleanetCode.TodoList.CLI.Infrastructure;

namespace CleanetCode.TodoList.CLI.Forms
{
    public class CompleteTaskForm : IForm, ITaskForm
    {
        public string Name => "Complete Task";

        public void Execute()
        {
            TaskDTO taskDTO = new TaskDTO();
            InputMessage.WriteLine("Please provide task id:");
            taskDTO.Id = Console.ReadLine();
            new CompleteTaskOperation().Execute(taskDTO);
            InfoMessage.WriteLine("Task was completed.");
        }
    }
}

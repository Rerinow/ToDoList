using CleanetCode.TodoList.BL.DTO;
using CleanetCode.TodoList.BL.Operations;
using CleanetCode.TodoList.CLI.Infrastructure;

namespace CleanetCode.TodoList.CLI.Forms
{
    public class DeleteTaskForm : IForm, ITaskForm
    {
        public string Name => "Delete task";

        public void Execute()
        {
            TaskDTO taskDTO = new TaskDTO();
            InputMessage.WriteLine("Please provide task id:");
            taskDTO.Id = Console.ReadLine();
            new DeleteTaskOperation().Execute(taskDTO);
            InfoMessage.WriteLine("Task was completed.");
        }
    }
}

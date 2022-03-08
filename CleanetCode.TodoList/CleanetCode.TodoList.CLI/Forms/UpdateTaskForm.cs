using CleanetCode.TodoList.BL.DTO;
using CleanetCode.TodoList.BL.Operations;
using CleanetCode.TodoList.CLI.Infrastructure;

namespace CleanetCode.TodoList.CLI.Forms
{
    public class UpdateTaskForm : IForm, ITaskForm
    {
        public string Name => "Update task";

        public void Execute()
        {
            var taskDTO = new TaskDTO();
            InputMessage.WriteLine("Please provide task id:");
            taskDTO.Id = Console.ReadLine();
            InputMessage.WriteLine("Please provide task name:");
            taskDTO.Name = Console.ReadLine();
            InputMessage.WriteLine("Please provide task description:");
            taskDTO.Description = Console.ReadLine();
            var updateTaskOperation = new UpdateTaskOperation();
            updateTaskOperation.Execute(taskDTO);
            InfoMessage.WriteLine("Task was updated.");
        }
    }
}

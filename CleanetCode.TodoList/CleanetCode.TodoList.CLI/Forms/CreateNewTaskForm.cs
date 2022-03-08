using CleanetCode.TodoList.BL.DTO;
using CleanetCode.TodoList.BL.Operations;
using CleanetCode.TodoList.CLI.Infrastructure;

namespace CleanetCode.TodoList.CLI.Forms
{
    public class CreateNewTaskForm : IForm, ITaskForm
    {
        public string Name => "Create new task";

        public void Execute()
        {
            var taskDTO = new TaskDTO();
            InputMessage.WriteLine("Please provide task name:");
            taskDTO.Name = Console.ReadLine();
            InputMessage.WriteLine("Please provide task description:");
            taskDTO.Description = Console.ReadLine();
            var createNewTaskOperation = new CreateNewTaskOperation();
            createNewTaskOperation.Execute(taskDTO);
            InfoMessage.WriteLine("Task was created.");
        }
    }
}

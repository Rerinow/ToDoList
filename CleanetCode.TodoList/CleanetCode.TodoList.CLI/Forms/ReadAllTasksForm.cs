using CleanetCode.TodoList.BL.DTO;
using CleanetCode.TodoList.BL.Operations;
using CleanetCode.TodoList.CLI.Infrastructure;

namespace CleanetCode.TodoList.CLI.Forms
{
    public class ReadAllTasksForm : IForm, ITaskForm
    {
        public string Name => "Show all tasks";

        public void Execute()
        {
            ReadAllTasksOperation allTasksOperation = new ReadAllTasksOperation();
            List<TaskDTO> tasksDTO = allTasksOperation.Execute();
            if (tasksDTO.Count != 0)
            {
                foreach (var taskDTO in tasksDTO)
                {
                    var taskStatus = taskDTO.IsCompleted ? "Completed" : "In Progress";
                    InfoMessage.WriteLine($"{taskDTO.Id} - {taskStatus} - {taskDTO.Name} {taskDTO.Description} ");
                }
                
            }
            else
            {
                InfoMessage.WriteLine("No tasks.");
            }
            
        }
    }
}

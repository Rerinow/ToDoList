using CleanetCode.TodoList.BL.DTO;
using CleanetCode.TodoList.BL.Operations;
using CleanetCode.TodoList.CLI.Infrastructure;

namespace CleanetCode.TodoList.CLI.Forms
{
    public class ReadAllTasksForm : IForm
    {
        public string Name => "Отобразить все задачи";

        public void Execute()
        {
            ReadAllTasksOperation allTasksOperation = new ReadAllTasksOperation();
            List<TaskDTO> tasksDTO = allTasksOperation.Execute();
            if (tasksDTO.Count != 0)
            {
                foreach (var taskDTO in tasksDTO)
                {
                    InfoConsole.WriteLine($"{taskDTO.Id} - {taskDTO.IsCompleted} - {taskDTO.Name} {taskDTO.Description} ");
                }
                
            }
            else
            {
                InfoConsole.WriteLine("Задачи отсутсвуют.");
            }
            
        }
    }
}

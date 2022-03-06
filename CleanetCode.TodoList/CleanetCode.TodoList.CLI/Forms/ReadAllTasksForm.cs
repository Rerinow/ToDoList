using CleanetCode.TodoList.BL.DTO;
using CleanetCode.TodoList.BL.Operations;

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
                    Console.WriteLine($"{taskDTO.Id} - {taskDTO.IsCompleted} - {taskDTO.Name} {taskDTO.Description} ");
                }
                
            }
            else
            {
                Console.WriteLine("Задачи отсутсвуют.");
            }
            
        }
    }
}

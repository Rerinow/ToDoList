using CleanetCode.TodoList.BL.CustomExceptions;
using CleanetCode.TodoList.BL.DTO;
using CleanetCode.TodoList.BL.Storages;

namespace CleanetCode.TodoList.BL.Operations
{
	public class CompleteTaskOperation
	{
		public void Execute(TaskDTO taskDTO)
		{
			if (UserSession.CurrentUser == null)
			{
				throw new UserSessionException("Error: Please register or login");
			}
			if(!Guid.TryParse(taskDTO.Id, out var taskId))
            {
				throw new ArgumentException("Error: Please provide correct task id");
            }
			var task = TaskStorage.GetTask(taskId);
            if (task == null)
            {
				throw new ArgumentNullException($"Error: {taskId} not found!");
			}
			task.IsCompleted = true;
			TaskStorage.SaveChanges();
		}

	}
}

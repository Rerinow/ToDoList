using CleanetCode.TodoList.BL.CustomExceptions;
using CleanetCode.TodoList.BL.DTO;
using CleanetCode.TodoList.BL.Storages;

namespace CleanetCode.TodoList.BL.Operations
{
	public class UpdateTaskOperation
	{
		public void Execute(TaskDTO taskDTO)
		{
			if (UserSession.CurrentUser == null)
			{
				throw new UserSessionException("Error: Please login or register");
			}
			if (!Guid.TryParse(taskDTO.Id, out var taskId))
			{
				throw new ArgumentException($"Error: Please provide correct task id");
			}
			var task = TaskStorage.GetTask(taskId);
            if (task == null)
            {
                throw new ArgumentNullException($"Error: {taskId} not found!");
            }
            if (!String.IsNullOrEmpty(taskDTO.Name))
            {
				task.Name = taskDTO.Name;
			}
			if (!String.IsNullOrEmpty(taskDTO.Description))
			{
				task.Description = taskDTO.Description;
			}
			task.UpdatedDate = DateTime.Now;
			TaskStorage.SaveChanges();
		}
    }
}

using CleanetCode.TodoList.BL.CustomExceptions;
using CleanetCode.TodoList.BL.DTO;
using CleanetCode.TodoList.BL.Storages;

namespace CleanetCode.TodoList.BL.Operations
{
	public class ReadAllTasksOperation
	{
		public List<TaskDTO> Execute()
		{
            if (UserSession.CurrentUser == null)
            {
				throw new UserSessionException("Ошибка: Пожалуйста зарегистрируйтесь или залогинтесь");
			}
			List<TaskDTO> tasksDTO = new List<TaskDTO>();
			var tasks = TaskStorage.GetTasks();
			foreach (var task in tasks)
            {
				tasksDTO.Add(new TaskDTO()
				{
					Id = task.Id.ToString(),
					Name = task.Name,
					Description = task.Description,
					IsCompleted = task.IsCompleted
				});
            }
			return tasksDTO;
		}
	}
}

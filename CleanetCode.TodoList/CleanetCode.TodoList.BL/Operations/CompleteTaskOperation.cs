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
				throw new UserSessionException("Ошибка: Пожалуйста зарегистрируйтесь или залогинтесь");
			}
			if(!Guid.TryParse(taskDTO.Id, out var taskId))
            {
				throw new ArgumentException($"Ошибка: Введите корректный формат идентификатор задачи");
            }
			var task = TaskStorage.GetTask(taskId);
            if (task == null)
            {
				throw new ArgumentNullException($"Ошибка: {taskId} не найден!");
			}
			task.IsCompleted = true;
		}

	}
}

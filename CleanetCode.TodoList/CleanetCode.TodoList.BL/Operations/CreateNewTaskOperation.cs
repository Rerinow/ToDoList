using CleanetCode.TodoList.BL.CustomExceptions;
using CleanetCode.TodoList.BL.DTO;
using CleanetCode.TodoList.BL.Models;
using CleanetCode.TodoList.BL.Storages;

namespace CleanetCode.TodoList.BL.Operations
{
	public class CreateNewTaskOperation
	{
		public void Execute(TaskDTO taskDTO)
		{
			if(UserSession.CurrentUser == null)
            {
				throw new UserSessionException("Ошибка: Пожалуйста зарегистрируйтесь или залогинтесь");
			}

			string? taskName = taskDTO.Name;

			if (String.IsNullOrEmpty(taskName))
			{
				throw new ArgumentNullException("Ошибка: Заполните название задачи!");
			}

			Models.Task newTask = new Models.Task()
			{
				Name = taskName,
				Description = taskDTO.Description,
				IsCompleted = false,
				UserId = UserSession.CurrentUser.Id
			};
			TaskStorage.CreateTask(newTask);

		}
	}
}

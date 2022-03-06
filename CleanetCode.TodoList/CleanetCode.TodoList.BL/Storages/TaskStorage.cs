namespace CleanetCode.TodoList.BL.Storages
{
	public static class TaskStorage
	{
        private static List<Models.Task> Tasks { get; set; } = new();

        public static bool CreateTask(Models.Task task)
        {
            Tasks.Add(task);
            return true;
        }
        public static List<Models.Task> GetTasks()
        {
            return Tasks;
        }
    }
}

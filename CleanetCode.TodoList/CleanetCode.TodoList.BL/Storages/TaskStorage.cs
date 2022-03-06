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
            return Tasks.FindAll(t => t.UserId == UserSession.CurrentUser.Id);
        }
        public static bool DeleteTask(Models.Task task)
        {
            return Tasks.Remove(task);
        }
        public static Models.Task GetTask(Guid guid)
        {
            return Tasks.Find(t => t.UserId == UserSession.CurrentUser.Id && t.Id == guid);
        }
    }
}

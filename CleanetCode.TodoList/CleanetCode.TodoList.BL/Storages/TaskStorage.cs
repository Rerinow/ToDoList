using System.Text.Json;

namespace CleanetCode.TodoList.BL.Storages
{
    public static class TaskStorage
    {
        private static List<Models.Task> Tasks { get; } = new();

        public static bool CreateTask(Models.Task task)
        {
            InitilizeTasks();
            Tasks.Add(task);
            return true;
        }
        public static List<Models.Task> GetTasks()
        {
            InitilizeTasks();
            return Tasks.FindAll(t => t.UserId == UserSession.CurrentUser.Id);
        }
        public static bool DeleteTask(Models.Task task)
        {
            InitilizeTasks();
            Tasks.Remove(task);
            return true;
        }
        public static Models.Task GetTask(Guid guid)
        {
            InitilizeTasks();
            return Tasks.Find(t => t.UserId == UserSession.CurrentUser.Id && t.Id == guid);
        }

        public static void SaveChanges()
        {
            File.WriteAllText(@".\tasks.json", JsonSerializer.Serialize(Tasks));
        }
        private static void InitilizeTasks()
        {
            if (Tasks.Count == 0 && File.Exists(@".\tasks.json"))
            {
                Tasks.AddRange(JsonSerializer.Deserialize<List<Models.Task>>(File.ReadAllText(@".\tasks.json")));
            }
        }
    }
}

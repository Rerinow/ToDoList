namespace CleanetCode.TodoList.BL.Models
{
	public class Task
	{
        public Task()
        {
			Id = Guid.NewGuid();
			CreatedDate = DateTime.Now;
        }
		public Guid Id { get; }
		public string Name { get; set; }
		public string Description { get; set; }
		public bool IsCompleted { get; set; }
		public DateTime CreatedDate { get; }
		public DateTime UpdatedDate { get; set; }
		public Guid UserId { get; set; }
	}
}

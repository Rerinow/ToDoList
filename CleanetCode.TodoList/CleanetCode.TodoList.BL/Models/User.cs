namespace CleanetCode.TodoList.BL.Models
{
	public class User
	{
		public User()
		{
			Id = Guid.NewGuid();
		}

		public Guid Id { get; }
		public string Email { get; init; }
	}
}

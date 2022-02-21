namespace CleanetCode.TodoList.BL.Operations
{
	public interface IOperation
	{
		string Name { get; }
		void Execute();
	}
}

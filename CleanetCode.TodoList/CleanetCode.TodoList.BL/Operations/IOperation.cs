namespace CleanetCode.TodoList.BL.Operations
{
	public interface IOperation
	{
		string Name { get; }
		string Description { get; }
		string OperationValue { get; set; }
		string OperationType { get; } // enum?
		string OperationStatus { get; }
		void Execute();
	}
}

namespace CleanetCode.TodoList.BL.Operations
{
	public class CreateNewTaskOperation : IOperation
	{
		public string Name { get; }
		public string Description { get; }
		public string OperationValue { get; set; }
		public string OperationType => "ActionWithValue";
		public string OperationStatus { get; private set; } = "Операция не выполнена";

		public void Execute()
		{
			throw new NotImplementedException();
		}
	}
}

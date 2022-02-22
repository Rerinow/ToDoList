namespace CleanetCode.TodoList.BL.Operations
{
	public class DeleteTaskOperation : IOperation
	{
		public string Name { get; }
		public string Description { get; }
		public string OperationValue { get; set; }
		public string OperationType => "OnlyAction";
		public string OperationStatus { get; private set; } = "Операция не выполнена";

		public void Execute()
		{
			throw new NotImplementedException();
		}
	}
}

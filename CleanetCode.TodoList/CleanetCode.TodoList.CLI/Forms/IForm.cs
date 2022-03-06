namespace CleanetCode.TodoList.CLI.Forms
{
    public interface IForm
    {
        public string Name { get; }
        void Execute();
    }
}

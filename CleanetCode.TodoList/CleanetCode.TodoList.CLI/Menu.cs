using CleanetCode.TodoList.BL;
using CleanetCode.TodoList.CLI.Forms;

namespace CleanetCode.TodoList.CLI
{
	public class Menu
	{
		private IForm[] forms;

        public Menu(IForm[] forms)
        {
            this.forms = forms;
        }

        public string[] GetFormNames()
        {
            List<string> formNames = new List<string>();

            for (int i = 0; i < forms.Length; i++)
            {
                if (forms[i] is IUserForm && UserSession.CurrentUser == null)
                {
                    IUserForm form = forms[i] as IUserForm;
                    formNames.Add($"{i} - {form.Name}");
                }

                if (forms[i] is ITaskForm && UserSession.CurrentUser != null)
                {
                    ITaskForm form = forms[i] as ITaskForm;
                    formNames.Add($"{i} - {form.Name}");
                }
            }
            return formNames.ToArray();
        }

        public void Enter(int formNumber)
		{
			if (formNumber < 0 || formNumber >= forms.Length)
			{
				throw new ArgumentOutOfRangeException("Error: Form not found!");
			}
            forms[formNumber].Execute();
		}
	}
}

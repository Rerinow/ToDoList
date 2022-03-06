using CleanetCode.TodoList.BL.Operations;
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
                IForm form = forms[i];
                formNames.Add($"{i} - {form.Name}");
            }
            return formNames.ToArray();
        }

        public void Enter(int formNumber)
		{
			if (formNumber < 0 || formNumber >= forms.Length)
			{
				throw new ArgumentOutOfRangeException("Ошибка: Форма не найдена!");
			}
            forms[formNumber].Execute();
		}
	}
}

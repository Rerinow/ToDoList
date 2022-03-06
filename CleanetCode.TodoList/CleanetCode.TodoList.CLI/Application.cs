using CleanetCode.TodoList.BL.CustomExceptions;
using CleanetCode.TodoList.CLI.Infrastructure;
using CleanetCode.TodoList.Infrastructure.CLI;

namespace CleanetCode.TodoList.CLI
{
	public class Application
	{
		private readonly Menu _menu;

		public Application(Menu menu)
		{
			_menu = menu;
		}

		public void Run()
		{
			bool userQuit = false;

			while (!userQuit)
			{
				try
				{
					List<string> formNames = new List<string>();
					formNames.Add("q - выйти из программы");
					formNames.AddRange(_menu.GetFormNames());


					InfoConsole.WriteLine(string.Join("\n", formNames));
					InputConsole.Write("Введите номер операции: ");
                
					string? userInput = Console.ReadLine();
					if (userInput != null && userInput.Trim().ToLower() == "q")
					{
						userQuit = true;
					}

					bool isNumber = int.TryParse(userInput, out int formNumber);
					if (isNumber)
					{
						_menu.Enter(formNumber);
					}
				}catch(KeyNotFoundException ex)
                {
					ErrorMessage.WriteLine(ex.Message);
				}
				catch(ArgumentOutOfRangeException ex)
                {
					ErrorMessage.WriteLine(ex.Message);
				}
				catch(AlreadyExistsObjectException ex)
                {
					ErrorMessage.WriteLine(ex.Message);
				}
				catch (UserSessionException ex)
                {
					ErrorMessage.WriteLine(ex.Message);
				}
				catch (ArgumentNullException ex)
				{
					ErrorMessage.WriteLine(ex.Message);
				}
				catch (ArgumentException ex)
                {
					ErrorMessage.WriteLine(ex.Message);
				}
				
			}
		}
	}
}

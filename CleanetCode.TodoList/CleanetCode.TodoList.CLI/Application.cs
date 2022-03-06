using CleanetCode.TodoList.BL.CustomExceptions;

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


					Console.WriteLine(string.Join("\n", formNames));
					Console.Write("Введите номер операции: ");
                
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
					Console.WriteLine(ex.Message);
                }
				catch(ArgumentOutOfRangeException ex)
                {
					Console.WriteLine(ex.Message);
				}
				catch(NullOrEmptyFieldException ex)
                {
					Console.WriteLine(ex.Message);
                }
				catch(AlreadyExistsObjectException ex)
                {
                    Console.WriteLine(ex.Message);
                }
				catch (UserSessionException ex)
                {
                    Console.WriteLine(ex.Message);
                }
			}
		}
	}
}

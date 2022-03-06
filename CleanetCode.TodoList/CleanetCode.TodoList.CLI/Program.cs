using CleanetCode.TodoList.CLI;
using CleanetCode.TodoList.BL.Operations;
using System.Text;
using CleanetCode.TodoList.CLI.Forms;

Console.OutputEncoding = Encoding.UTF8;

IForm[] forms = new IForm[]
{
    new CreateNewUserForm(),
    new LoginUserForm(),
    new CreateNewTaskForm(),
    new ReadAllTasksForm(),
};

Menu menu = new Menu(forms);
Application application = new Application(menu);
application.Run();

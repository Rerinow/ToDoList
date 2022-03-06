using CleanetCode.TodoList.CLI;
using System.Text;
using CleanetCode.TodoList.CLI.Forms;

Console.OutputEncoding = Encoding.UTF8;
IForm[] forms = new IForm[]
{
        new CreateNewTaskForm(),
        new ReadAllTasksForm(),
        new CompleteTaskForm(),
        new UpdateTaskForm(),
        new DeleteTaskForm(),
        new CreateNewUserForm(),
        new LoginUserForm(),
};

Menu menu = new Menu(forms);
Application application = new Application(menu);
application.Run();

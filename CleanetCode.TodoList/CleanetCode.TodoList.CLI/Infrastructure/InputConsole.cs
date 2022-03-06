using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanetCode.TodoList.CLI.Infrastructure
{
    public static class InputConsole
    {
        public static void WriteLine(string message)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(message);

        }
        public static void Write(string message)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(message);

        }
    }
}

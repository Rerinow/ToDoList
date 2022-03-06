using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanetCode.TodoList.Infrastructure.CLI
{
    public static class ErrorMessage
    {
        public static void WriteLine(string message) 
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message); 
        
        }
    }
}

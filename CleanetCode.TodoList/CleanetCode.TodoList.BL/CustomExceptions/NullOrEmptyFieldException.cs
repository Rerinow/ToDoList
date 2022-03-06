using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanetCode.TodoList.BL.CustomExceptions
{
    public class NullOrEmptyFieldException : Exception
    {
        public NullOrEmptyFieldException()
        {
        }
        public NullOrEmptyFieldException(string message)
            : base(message)
        {
        }
        public NullOrEmptyFieldException(string message, Exception inner)
        : base(message, inner)
        {
        }
    }
}

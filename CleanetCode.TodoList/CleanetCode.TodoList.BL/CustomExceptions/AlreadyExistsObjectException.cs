using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanetCode.TodoList.BL.CustomExceptions
{
    public class AlreadyExistsObjectException : Exception
    {
        public AlreadyExistsObjectException()
        {
        }
        public AlreadyExistsObjectException(string message)
            : base(message)
        {
        }
        public AlreadyExistsObjectException(string message, Exception inner)
        : base(message, inner)
        {
        }
    }
}

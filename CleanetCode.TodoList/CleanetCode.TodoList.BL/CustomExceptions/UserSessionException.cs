using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanetCode.TodoList.BL.CustomExceptions
{
    public class UserSessionException : Exception
    {
        public UserSessionException()
        {

        }

        public UserSessionException(string message):base(message)
        {

        }
        public UserSessionException(string message, Exception inner): base(message, inner)
        {

        }
    }
}

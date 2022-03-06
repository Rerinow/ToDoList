using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanetCode.TodoList.CLI.Forms
{
    public interface IForm
    {
        public string Name { get; }
        void Execute();
    }
}

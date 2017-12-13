using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PipeManager.Command
{
    class CommandException : Exception
    {
        CommandException() : base() { }

        CommandException(string message) : base(message) { }

        CommandException(string message, Exception ex) : base(message, ex) { }
    }
}

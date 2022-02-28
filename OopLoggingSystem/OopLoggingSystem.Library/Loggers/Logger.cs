using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopLoggingSystem.Library.Loggers
{
    public abstract class Logger
    {
        public abstract void Write(LogEntry entry);

    }
}

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopLoggingSystem.Library.Loggers
{
    internal class DebugWindowLogger : Logger
    {
        public override void Write(LogEntry entry)
        {
            if (Debugger.IsAttached)
            {
                Debug.WriteLine($"[{DateTime.Now:yyyy-MM-dd HH:mm:ss.fff}] [{entry.LogLevel}] [{entry.Message}]");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopLoggingSystem.Library.Loggers
{
    internal class ConsoleLogger : Logger
    {

        public override void Write(LogEntry entry)
        {
            Console.WriteLine($"[{DateTime.Now:yyyy-MM-dd HH:mm:ss.fff}] [{entry.LogLevel}] [{entry.Message}]");
        }
    }
}

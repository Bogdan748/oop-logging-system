using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopLoggingSystem.Library
{
    public class LogEntry
    {
        public LogEntry(LogLevel logLevel, string message)
        {
            LogLevel = logLevel;
            Message = message;
        }

        public LogLevel LogLevel { get; }

        public string Message { get; }


    }
}

using OopLoggingSystem.Library.Loggers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopLoggingSystem.Library.Factories
{
    public class FileLoggerFactory : LoggerFactory
    {
        public FileLoggerFactory(string filePath)
        {
            FilePath = filePath;
        }
        public string FilePath { get; }

        internal override Logger Create()
        {
            return new FileLogger(FilePath);
        }
    }
}

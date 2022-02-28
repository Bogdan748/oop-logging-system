using OopLoggingSystem.Library.Loggers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopLoggingSystem.Library.Factories
{
    public abstract class LoggerFactory
    {
        internal  abstract Logger Create();
    }
}

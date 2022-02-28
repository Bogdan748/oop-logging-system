using OopLoggingSystem.Library;
using OopLoggingSystem.Library.Factories;
using OopLoggingSystem.Library.Loggers;
using System;

namespace OopLoggingSystem.Terminal
{
    class Program
    {
        static void Main(string[] args)
        {
            //init logger
            //ApplicationLog.Initialize(new ConsoleLoggerFactory());

            ApplicationLog.Initialize(new FileLoggerFactory(@"D:\Fast Track IT\Github4\oop-logging-system\FILELOGGER\errorLog.txt"));

            int[] array = ArrayHelper.ReadFromConsole("Array");
            ArrayHelper.PrintToConsole("Array", array);
        }
    }
}

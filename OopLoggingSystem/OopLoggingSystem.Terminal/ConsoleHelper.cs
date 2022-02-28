using OopLoggingSystem.Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopLoggingSystem.Terminal
{
    public static class ConsoleHelper
    {
        public static int ReadNumeber(string label, int maxAttempts=3, int defaultValue=0)
        {
            if (label is not null)
            {
                Console.Write(label);
            }

            int attempts = 1;
            while (attempts<= maxAttempts)
            {
                string input = Console.ReadLine();

                if (int.TryParse(input, out int result))
                {
                    return result;
                }
                else
                {
                    attempts++;
                    Console.WriteLine($"Value '{input}' doesn't represent a valid number, try again");
                }
            }

            string message = $"Exceeded max attempts {maxAttempts}, using {defaultValue}";
            Console.WriteLine(message);

            ApplicationLog.Write(new LogEntry (LogLevel.Warning, message));

            return defaultValue;
        }
    }
}

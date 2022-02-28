using OopLoggingSystem.Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopLoggingSystem.Terminal
{
    public static class ArrayHelper
    {
        public static int[] ReadFromConsole(string label)
        {
            Console.WriteLine(label);
            int n = ConsoleHelper.ReadNumeber("No. of elements=");

            if (n < 0)
            {
                ApplicationLog.Write(new LogEntry(LogLevel.High, $"Number of elements ('{n}') must be positive."));
                return new int[0];
            }

            int[] result = new int[n];

            for (int i =0; i < n; i++)
            {
                int elem = ConsoleHelper.ReadNumeber($"Elem[{i}]=");
                if (elem < 0)
                {
                    ApplicationLog.Write(new LogEntry(LogLevel.High, $"Elements at index {i} should be positive, but was {elem}"));
                    elem = 0;
                }

                result[i] = elem;
            }

            return result;
        }


        public static void PrintToConsole(string label, int[] array)
        {
            string elements = string.Join(", ", array);
            Console.WriteLine($"{label} : [{elements}]");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17._06._22_задание_3
{
    class Program
    {
        static class ConsolePrinter
        {
            public enum OutputColors { Blue = 9, Green = 10, Red = 12 }

            public static void Print(string text, OutputColors outputColor)
            {
                Console.ForegroundColor = (ConsoleColor)Convert.ToInt32(outputColor);
                Console.WriteLine(text);
            }
        }
        static void Main(string[] args)
        {
            ConsolePrinter.Print("Red color", ConsolePrinter.OutputColors.Red);
            ConsolePrinter.Print("Green color", ConsolePrinter.OutputColors.Green);
            ConsolePrinter.Print("Blue color", ConsolePrinter.OutputColors.Blue);

            Console.ReadKey(true);
        }

    }
}    


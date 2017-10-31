using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                    Console.BackgroundColor = ConsoleColor.Magenta;
                    Console.Beep(900, 300);
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.Beep(300, 500);
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.Beep(700, 200);
                }
                else
                {
                    Console.WriteLine(i);
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.Beep(1200, 700);
                }

            }
            Console.ReadKey();
        }
    }
}

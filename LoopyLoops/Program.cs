using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopyLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Press enter a number...");
            int number = int.Parse(Console.ReadLine());

            for (int x = 1; x <= number; x++)
            {
                Console.WriteLine(x);
            }

            Console.ReadKey();

            Console.WriteLine("Press something now...");
            Console.ReadLine();

            int numbera = 1;

            while (numbera <= 10)
            {
                Console.WriteLine(number);
                number++;
            }

            Console.ReadKey();
        }
    }
}

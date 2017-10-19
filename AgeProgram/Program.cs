using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your age: ");
            int age = int.Parse(Console.ReadLine());

            if (age < 0)
            {
                Console.WriteLine("Sorry, what?");
            }
            else if (age < 13)
            {
                Console.WriteLine("You're a child.");
            }
            else if (age < 20)
            {
                Console.WriteLine("You're a teenager.");
            }
            else if (age < 101)
            {
                Console.WriteLine("You're an adult.");
            }
            else
            {
                Console.WriteLine("You are either dead or getting there.");
            }
            Console.ReadKey();
        }
    }
}

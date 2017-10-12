using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WelcomeMessage
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your nama here: ");
            string name = Console.ReadLine();
            Console.Write("Enter your place of living here: ");
            string location = Console.ReadLine();
            Console.WriteLine($"Welcome to le pogram, {name}. Now I know you live at {location}!");
            Console.ReadLine();
        }
    }
}

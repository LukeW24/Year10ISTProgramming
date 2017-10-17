using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberFun
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a value of X: ");
            float X = float.Parse(Console.ReadLine());
            Console.Write("Enter a value for Y: ");
            float Y = float.Parse(Console.ReadLine());

            Console.WriteLine($"{X} + {Y} = {(X + Y)}");

            Console.WriteLine($"{X} x {Y} = {(X * Y)}");

            Console.WriteLine($"{X} - {Y} = {(X - Y)}");

            Console.WriteLine($"{X} / {Y} = {(X / Y)}");

            Console.ReadKey();


        }
    }
}

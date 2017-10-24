using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessMyNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int rand = rnd.Next(1, 101);

            int guess = -1;

            int count = 0;

            while (guess != rand)
            {
                count++;
                Console.Write("Guess: ");
                guess = int.Parse(Console.ReadLine());
                if(guess < rand)
                {
                    Console.WriteLine("Too low!");
                }
                else if (guess > rand)
                {
                    Console.WriteLine("Too high!");
                }
                else
                {
                    Console.WriteLine($"{guess} is right! You are now the good! It took you {count} attempts!");
                    Console.ReadKey();
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magic8_Ball
{
    class Program
    {
        static void Main(string[] args)
        {
            playGame();
        }

        private static void playGame()
        {
            string[] answers = { "No doubt!", "Absolutely not!", "Unsure.",
                                 "Yeah, why not.", "Ask a decent question, please.",
                                 "NEIN, NEIN, NEIN!!!", "I suppose.", "YA!", "God no.", "That's unthinkable." };

            Console.WriteLine("Type 'exit' to leave. Ask a yes or no question and i will reward you with a most supple reward...");

            if (Console.ReadLine() != "exit")
            {
                Random rnd = new Random();

                Console.WriteLine(answers[rnd.Next(10)]);

                Console.WriteLine("");

                playGame();
            }
        }
    }
}

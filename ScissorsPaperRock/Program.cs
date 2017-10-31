using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScissorsPaperRock
{
    class Program
    {
        static void Main(string[] args)
        {
            int UserScore = 0;
            int ComputerScore = 0;
            bool repeat = true;

            while (repeat == true)
            {
                string result = "Draw";
                PrintScore(ref UserScore, ref ComputerScore);
                string UserChoice = UserTurn();
                String ComputerChoice = ComputerTurn();
                result = DetermineWinner(UserChoice,ComputerChoice);
                GiveFeedback(result, UserChoice, ComputerChoice);
                UpdateScores(result, ref UserScore, ref ComputerScore);
                repeat = PlayAgain();
            }
        }

        private static bool PlayAgain()
        {
            Console.WriteLine("Play again? Y/N");
            string choice = Console.ReadLine().ToLower();
            if (choice == "y" || choice == "Yes")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private static void UpdateScores(string result, ref int userScore, ref int computerScore)
        {
            if (result == "Win")
            {
                userScore++;
            }
            else if(result == "Lose")
            {
                computerScore++;
            }
        }

        private static void GiveFeedback(string result, string userChoice, string computerChoice)
        {
            
        }

        private static string DetermineWinner(string userChoice, string computerChoice)
        {
            if (userChoice == "Rock")
            {
                if (computerChoice == "Rock")
                {
                    return "Draw";
                }
                else if (computerChoice == "Paper")
                {
                    return "Lose";
                }
                else if(computerChoice == "Scissors")
                {
                    return "Win";
                }
            }
            else if (userChoice == "Paper")
            {
                if (computerChoice == "Rock")
                {
                    return "Win";
                }
                else if (computerChoice == "Paper")
                {
                    return "Draw";
                }
                else if (computerChoice == "Scissors")
                {
                    return "Lose";
                }
            }
            else if (userChoice == "Scissors")
            {
                if (computerChoice == "Rock")
                {
                    return "Lose";
                }
                else if (computerChoice == "Paper")
                {
                    return "Win";
                }
                else if (computerChoice == "Scissors")
                {
                    return "Draw";
                }
            }
        }

        private static string ComputerTurn()
        {
            
        }

        private static string UserTurn()
        {
            
        }

        private static void PrintScore(ref int userScore, ref int computerScore)
        {
            Console.WriteLine("User Score: 100\t\tComputer Score: 100");
        }
    }
}

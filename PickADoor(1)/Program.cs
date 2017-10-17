using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PickADoor_1_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Pick a number between 1 and 5: ");
            string selection = Console.ReadLine();

            if (selection == "1")
            {
                Console.WriteLine("Number 1 is Mullum Zoe");
            }
            else if (selection == "2")
            {
                Console.WriteLine("Number 2 is FoodWorks Zoe");
            }
            else if (selection == "3")
            {
                Console.WriteLine("Number 3 is Scout Zoe");
            }
            else if (selection == "4")
            {
                Console.WriteLine("Number 4 is Cadet Pryor");
            }
            else if (selection == "5")
            {
                Console.WriteLine("Number 5 is the Stying Flar Fish");
            }
            else
            {
                Console.WriteLine("SO MANY ZOES");
            }

            Console.ReadKey();
        }
    }
}

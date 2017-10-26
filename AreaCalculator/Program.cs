using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string choice = "";
            while (choice != "4")
            {
                // Menu
                Console.Clear();
                Console.WriteLine("Choose an option...");
                Console.WriteLine("1. Area of a rectangle");
                Console.WriteLine("2. Area of a triangle");
                Console.WriteLine("3. Area of a circle");
                Console.WriteLine("4. Exit");
                Console.WriteLine("5. Surprise...");
                choice = Console.ReadLine();

                if (choice == "1")
                {
                    // Rectangle
                    Console.WriteLine();
                    Console.Write("Width: ");
                    float width = float.Parse(Console.ReadLine());
                    Console.Write("Length: ");
                    float length = float.Parse(Console.ReadLine());
                    Console.WriteLine("Area: " + (width * length));
                }
                else if (choice == "2")
                {
                    // Triangle
                    Console.WriteLine();
                    Console.Write("Base: ");
                    float width = float.Parse(Console.ReadLine());
                    Console.Write("Height: ");
                    float height = float.Parse(Console.ReadLine());
                    Console.WriteLine("Area: " + (0.5 * width * height));
                }
                else if (choice == "3")
                {
                    // Circle
                    Console.WriteLine();
                    Console.Write("Radius: ");
                    float radius = float.Parse(Console.ReadLine());
                    Console.WriteLine("Area: " + (Math.PI * radius * radius));
                }
                else if (choice == "4")
                {
                    break;
                }
                else if (choice == "5")
                {
                    Console.WriteLine("No.");
                }

                // Wait
                Console.WriteLine();
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
            }
        }
    }
}

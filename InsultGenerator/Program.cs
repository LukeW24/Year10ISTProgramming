using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsultGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            string name = GetName();

            GenerateInsult(name, rnd);
        }
        private static string GetName()
        {
            Console.WriteLine("Give me your name and I'll say something nice...");
            return Console.ReadLine();
        }
        private static void GenerateInsult(string name, Random rnd)
        {
            Console.WriteLine(name + ", you're " + GetAdjective(rnd) + " " + GetCompoundAdjective(rnd) + " " + GetObject(rnd));
            Menu(name, rnd);
        }
        private static void Menu(string name, Random rnd)
        {
            Console.Write("More? Y/N");
            if (Console.ReadLine() == "y")
            {
                GenerateInsult(name, rnd);
            }
        }
        private static string GetObject(Random rnd)
        {
            string[] objects = { "Zoe Pryor", "Mac-user", "philosopher", "English teacher" };
            return objects[rnd.Next(3)];
        }
        private static string GetCompoundAdjective(Random rnd)
        {
            string[] compoundAdjectives = { "vapour-puffing", "meth-mongering", "carb-crushing", "gender-blending" };
            return compoundAdjectives[rnd.Next(3)];
        }
        private static string GetAdjective(Random rnd)
        {
            string[] adjectives = { "a cheesy", "a mouldy", "a thick", "an albino", "a creamy" };
            return adjectives[rnd.Next(4)];
        }
    }
}

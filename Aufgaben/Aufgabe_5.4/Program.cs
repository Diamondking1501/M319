using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_5._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string answer;

            do
            {
                Console.WriteLine("What's your name?");
                string name = Console.ReadLine();

                Console.WriteLine("Greetings " + name + "!\n");
                
                Console.WriteLine("Do you want to greet another person? (y/n)");
                answer = Console.ReadLine();
            } while (answer == "y");

            Console.WriteLine("Goodbye!");
        }
    }
}

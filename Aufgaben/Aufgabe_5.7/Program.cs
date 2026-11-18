using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_5._7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello! Please enter a step value for the loop (between 1 and 30):");
            int step = int.Parse(Console.ReadLine());

            for (int i = 3; i <= 30; i += step)
            {
                Console.WriteLine(i);

                Console.WriteLine();
            }
        }
    }
}

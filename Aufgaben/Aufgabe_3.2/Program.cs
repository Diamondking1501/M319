using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_3._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numbrero;

            Console.WriteLine("Ganze Zahl bitte: ");
            numbrero = Convert.ToInt32(Console.ReadLine());

            if (numbrero == 0)
            {
                Console.WriteLine($"Zahl: {numbrero}\nDie Zahl ist genau 0 Judihui!");
            }
            else if (numbrero < 0)
            {
                Console.WriteLine($"Zahl: {numbrero}\nDie Zahl ist negativ :(");
            }
            else
            {
                Console.WriteLine($"Zahl: {numbrero}\nDie Zahl ist positiv :D");
            }
        }
    }
}

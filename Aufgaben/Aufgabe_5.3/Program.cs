using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_5._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int addition = 1;
            int sum = 0;

            while (addition <= 100)
            {
                sum += addition++;
            }

            Console.WriteLine("Die Summe der Zahlen von 1 bis 100 ist: " + sum);
        }
    }
}

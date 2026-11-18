using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_4._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 12;
            int b = 5;
            int c = 3;

            int x = a + b * c;
            int y = a - b + c;
            int z = a / c + b;
            int w = a % b * c;

            Console.WriteLine("x = " + x);
            Console.WriteLine("y = " + y);
            Console.WriteLine("z = " + z);
            Console.WriteLine("w = " + w);
            // x = 27
            // y = 10
            // z = 7
            // w = 6
            Console.ReadLine();
        }
    }
}

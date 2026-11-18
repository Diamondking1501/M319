using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_5._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int zahl = 1;
            while (zahl <= 20)
            {
                Console.WriteLine(zahl);
                zahl++;
            }
            Console.WriteLine("-------------");
            int gerade = 2;
            while (gerade <= 30)
            {
                Console.WriteLine(gerade);
                gerade += 2;
            }
            Console.WriteLine("-------------");
            int fuenfer = 5;
            while (fuenfer <= 50)
            {
                Console.WriteLine(fuenfer);
                fuenfer += 5;
            }
        }
    }
}

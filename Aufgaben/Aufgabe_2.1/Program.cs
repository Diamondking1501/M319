using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_2._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Erste Zahl: ");
            int zahl1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Zweite Zahl: ");
            int zahl2 = int.Parse(Console.ReadLine());

            int summe = zahl1 + zahl2;
            int differenz = zahl1 - zahl2;
            int produkt = zahl1 * zahl2;
            int rest = zahl1 % zahl2;

            Console.WriteLine("Summe: " + summe);
            Console.WriteLine("Differenz: " + differenz);
            Console.WriteLine("Produkt: " + produkt);
            Console.WriteLine("Rest: " + rest);
        }
    }
}

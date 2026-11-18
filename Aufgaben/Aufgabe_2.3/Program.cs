using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_2._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Stunden: ");
            double hours = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Minuten: ");
            double minutes = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Sekunden: ");
            double seconds = Convert.ToDouble(Console.ReadLine());

            minutes = hours * 60 + minutes;
            seconds = minutes * 60 + seconds;

            Console.WriteLine($"Gesamtdauer: {seconds}");
            Console.ReadKey();
        }
    }
}

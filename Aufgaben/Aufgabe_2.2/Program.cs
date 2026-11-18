using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_2._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Länge in Metern?");
            double Laenge = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Breite in Metern?");
            double Breite = Convert.ToDouble(Console.ReadLine());

            double Umfang = 2 * (Laenge + Breite);
            double Flaeche = Laenge * Breite;

            Console.WriteLine($"Fläche: {Flaeche}m²\nUmfang: {Umfang} m");
        }
    }
}

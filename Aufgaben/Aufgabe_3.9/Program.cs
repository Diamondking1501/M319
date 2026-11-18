using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_3._9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string artikel = "Tastatur";
            int anzahl = 3;
            double einzelpreis = 39.90;
            double gesamtpreis = anzahl * einzelpreis;
            if (gesamtpreis > 100)
            {
                gesamtpreis = gesamtpreis * 0.90;
            }
            else
            {
                Console.WriteLine("Kein Rabatt gewährt.");
            }
            Console.WriteLine("Gesamtpreis von " + anzahl + " " + artikel + ": CHF " + gesamtpreis);
            
            Console.ReadLine();
        }
    }
}
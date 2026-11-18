using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_1._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*  Erstelle ein Konsolenprogramm, das folgende Informationen vom Benutzer einliest:
             *      ▪ Vorname
             *      ▪ Nachname
             *      ▪ Alter
             *      ▪ Körpergrösse in Metern
             *  Speichere alle Eingaben in Variablen mit passenden Datentypen.
             */

            string vorname;
            string nachname;
            int alter;
            double groesse;

            Console.WriteLine("Wie lautet dein Vorname: ");
            vorname = Console.ReadLine();

            Console.WriteLine("Wie lautet dein Nachname: ");
            nachname = Console.ReadLine();

            Console.WriteLine("Was ist dein Alter: ");
            alter = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Was ist deine Grösse: ");
            groesse = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine("Hallo " + vorname + " " + nachname + "\nDu bist " + alter + " Jahre alt und " + groesse + " Meter gross.");
            Console.ReadKey();

        }
    }
}

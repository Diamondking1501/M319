using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_3._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int maxPoints;
            int points;

            Console.WriteLine("Wie viele Punkte hast du erreicht: ");
            points = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Was ist die maximale Punktzahl: ");
            maxPoints = Convert.ToInt32(Console.ReadLine());

            double result = points * maxPoints / 100;

            if (result >= 60)
            {
                Console.WriteLine($"Erreichte Punkte: {points}\nMaximale Punkte: {maxPoints}\n\nErgebnis: {result} %\nDie Prüfung wurde bestanden.");
            }
            else
            {
                Console.WriteLine($"Erreichte Punkte: {points}\nMaximale Punkte: {maxPoints}\n\nErgebnis: {result} %\nDie Prüfung wurde nicht bestanden.");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_5._8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int punkte;

            do
            {
                Console.Write("Punkte eingeben (0 - 100): ");
                punkte = Convert.ToInt32(Console.ReadLine());

                if (punkte < 0 || punkte > 100)
                {
                    Console.WriteLine("Ungültige Eingabe. Bitte erneut versuchen.");
                }

            } while (punkte < 0 || punkte > 100);

            Console.WriteLine($"Erreichte Punkte: {punkte}");
        }
    }
}

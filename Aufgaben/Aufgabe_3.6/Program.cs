using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_3._6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Einfacher Taschenrechner");
            Console.Write("Geben Sie die erste Zahl ein: ");
            int zahl1 = int.Parse(Console.ReadLine());
            Console.Write("Geben Sie die zweite Zahl ein: ");
            int zahl2 = int.Parse(Console.ReadLine());
            Console.Write("Geben Sie die gewünschte Rechenoperation ein in einer Zahl.(1 Addition, 2 Subtraktion, 3 Multiplikation, 4 Division): ");
            string operation = Console.ReadLine();

            int ergebnis = 0;
            bool gültigeOperation = true;

            switch (operation)
            {
                case "1":
                    ergebnis = zahl1 + zahl2;
                    break;
                case "2":
                    ergebnis = zahl1 - zahl2;
                    break;
                case "3":
                    ergebnis = zahl1 * zahl2;
                    break;
                case "4":
                    if (zahl2 != 0)
                        ergebnis = zahl1 / zahl2;
                    else
                        Console.WriteLine("Fehler: Division durch null ist nicht erlaubt.");
                    break;
                default:
                    Console.WriteLine("Ungültige Operation.");
                    gültigeOperation = false;
                    break;
            }

            if (gültigeOperation)
                Console.WriteLine($"Das Ergebnis ist: {ergebnis}");
            Console.ReadLine();
        }

    }

}

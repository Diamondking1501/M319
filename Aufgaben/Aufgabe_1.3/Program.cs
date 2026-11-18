using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_1._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*  Erstelle ein Konsolenprogramm für ein Spiel. Speichere folgende Werte:
                    ▪ Name des Spielers
                    ▪ Aktueller Punktestand
                    ▪ Maximale Anzahl Leben: 3
                Der Name und der Punktestand sollen als Variablen gespeichert werden. Die maximale Anzahl Leben 
                soll als Konstante gespeichert werden. Verwende passende Datentypen und aussagekräftige Namen.
                Gib die Werte so aus:
                    Spieler: Max
                    Punktestand: 1250
                    Maximale Anzahl Leben: 3
                Hinweis
                    Eine Konstante deklarierst du mit dem Schlüsselwort const.
            */

            string spielerName = "Max";
            int punktestand = 1250;
            const int maximaleLeben = 3;

            Console.WriteLine($"Spieler: {spielerName}\nPunktestand: {punktestand}\nMaximale Anzahl Leben: {maximaleLeben}");
            Console.ReadKey();

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_3._10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Fahrzeugtyp (1 = Motorrad, 2 = Auto, 3 = Lieferwagen): ");
            int fahrzeug = Convert.ToInt32(Console.ReadLine());
            Console.Write("Parkdauer in Stunden: ");
            int stunden = Convert.ToInt32(Console.ReadLine());
            Console.Write("Mitglied (1 = Ja, 2 = Nein): ");
            int mitglied = Convert.ToInt32(Console.ReadLine());
            double stundenpreis = 0;
            switch (fahrzeug)
            {
                // Falsche Preisangaben korrigiert: Motorrad = 2.00, Auto = 3.50, Lieferwagen = 5.00
                case 1:
                    stundenpreis = 2.00;
                    break;
                case 2:
                    stundenpreis = 3.50;
                    break;
                case 3:
                    stundenpreis = 5.00;
                    break;
            }
            // Parkgebühr korrigiert vorher war + statt * und die Berechnung war falsch
            double gebuehr = stundenpreis * stunden;
            //
            if (stunden >= 5)
            {
                gebuehr = gebuehr * 0.90;
            }
            // Mitgliederrabatt war falsch, 1 = Ja, 2 = Nein, daher muss der Rabatt nur gewährt werden, wenn mitglied == 1
            if (mitglied == 1)
            {
                gebuehr = gebuehr * 0.85;
            }
            // Ausgabe der Parkgebühr mit zwei Nachkommastellen hinzugefügt
            Console.WriteLine("Parkgebühr: CHF " + gebuehr.ToString("F2"));
            // Das Konsolenfenster bleibt geöffnet bis die Enter-Taste gedrückt wird
            Console.ReadLine();
        }
    }
}

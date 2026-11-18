using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_5._9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int max = int.MinValue;
            for (int i = 0; i < 3; i++)
            {
                int number;
                bool isValidInput = false;
                while (!isValidInput)
                {
                    Console.Write($"Bitte geben Sie die {i + 1}. ganze Zahl ein: ");
                    string input = Console.ReadLine();
                    if (int.TryParse(input, out number))
                    {
                        isValidInput = true;
                        sum += number;
                        if (number > max)
                        {
                            max = number;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Ungültige Eingabe. Bitte geben Sie eine gültige ganze Zahl ein.");
                    }
                }
            }
            double average = sum / 3.0;
            Console.WriteLine($"\nSumme: {sum}");
            Console.WriteLine($"Durchschnitt: {average}");
            Console.WriteLine($"Größte Zahl: {max}");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_3._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age;
            Console.WriteLine("Hallo\nIch möchte wissen wie alt du bist muahahaha");
            age = Convert.ToInt32(Console.ReadLine());

            if (age >= 18)
            {
                Console.WriteLine($"Mit deinem Alter von {age}, bist du volljährig.");
            }
            else
            {
                Console.WriteLine($"Mit deinem Alter von {age}, bist du minderjährig.");
            }
        }
    }
}

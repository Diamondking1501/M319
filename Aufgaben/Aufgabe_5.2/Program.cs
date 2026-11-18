using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_5._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countdown = 10;
            while (countdown >= 1)
            {
                Console.WriteLine(countdown);
                countdown--;
                if (countdown == 0)
                {
                    Console.WriteLine("Start!");
                }
            }
        }
    }
}

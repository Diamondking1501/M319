using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Aufgabe_1._1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string productName = "Notebook";
            int productAmount = 12;
            double productPrice = 899.90;

            Console.WriteLine("Produkt: " +  productName + "\nAnzahl: " + productAmount + "\nPreis: " + productPrice);

        }
    }
}

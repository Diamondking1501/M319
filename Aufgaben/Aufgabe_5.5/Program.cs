using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_5._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                bool checkout = false;
                int totalPrice = 0;

                Console.WriteLine("*********************");
                Console.WriteLine("**** Online-Shop ****");
                Console.WriteLine("*********************\n");

                Console.WriteLine("Products: \n1. Keyboard - CHF 45.-\n2. Mouse - CHF 25.-\n3. Headset - CHF 70.-\n______________________\n");

                do
                {
                    Console.WriteLine("Please select a product (1-3) or type 'checkout' to finish your order:");
                    Console.WriteLine("Your current order: CHF " + totalPrice + ".-");

                    string input = Console.ReadLine();

                    int price = 0;

                    switch (input)
                    {
                        case "1":
                            Console.WriteLine("You selected Keyboard - CHF 45.-");
                            price = 45;
                            break;

                        case "2":
                            Console.WriteLine("You selected Mouse - CHF 25.-");
                            price = 25;
                            break;

                        case "3":
                            Console.WriteLine("You selected Headset - CHF 70.-");
                            price = 70;
                            break;

                        case "checkout":
                            checkout = true;
                            Console.WriteLine("Thank you for your order!");
                            break;

                        default:
                            Console.WriteLine("Invalid selection. Please try again.");
                            break;
                    }

                    if (price > 0)
                    {
                        Console.WriteLine("How many would you like to order?");
                        int amount = Convert.ToInt32(Console.ReadLine());

                        totalPrice += price * amount;
                    }

                } while (!checkout);

                Console.WriteLine("\n--- Checkout ---");

                Console.WriteLine("Total price: CHF " + totalPrice + ".-");

                double discount = 0;

                if (totalPrice >= 150)
                {
                    discount = totalPrice * 0.10;
                }

                double finalPrice = totalPrice - discount;

                Console.WriteLine("Discount: CHF " + discount + ".-");
                Console.WriteLine("Final price: CHF " + finalPrice + ".-");
            }
        }
    }
}

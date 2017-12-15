using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tunnikontroll_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("Total Pizza Restaurant");
            Console.WriteLine("Jalopeno way 66");
            Console.WriteLine("-------------------------------------------");
            double totalPrice = 0;
            double price = 0;

            do
            {
                price = SetNumber("Enter price, enter #1 to QUIT: ");
                totalPrice = totalPrice + price;
            }
            while (price != 1);
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine($"Subtoital: €{totalPrice}");

            double gratuity = totalPrice * 0.15;
            Console.WriteLine($"15% Gratuity: €{gratuity}");

            double grandTotal = totalPrice - gratuity;
            Console.WriteLine($"Grand Total is: €{grandTotal}");
            Console.ReadKey();


            double SetNumber(string outputText)
            {
                double parse;
                Console.Write(outputText);
                string tempInput = Console.ReadLine();
                while (!double.TryParse(tempInput, out parse))
                {
                    Console.WriteLine("See polnud hind, palun lisa siia numbrid!");
                    Console.Write(outputText);
                    tempInput = Console.ReadLine();
                }
                return double.Parse(tempInput);
            }
        }
    }

}


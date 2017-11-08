using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalkulaator_1
{
    class Program
    {
        static void Main(string[] args)
        {

            double sisend1;
            double sisend2;
            double vastus;
            string tehe;

            // Proovin kasutada tunnis õpitut ja kahte uut asja:

            Console.WriteLine("KALKULAATOR\n");
            Console.WriteLine("-------------------------------------");

            sisend1 = SetNumber("Sisesta esimene number\n");

            Console.WriteLine("Vali tehe: (+,-,*,/,%)\n");
            tehe = Console.ReadLine();
            Console.WriteLine("-------------------------------------");

            sisend2 = SetNumber("Sisesta teine number\n");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("VASTUS ON: ");

            // õppisin kasutama c#-s switchi...
            switch (tehe)
            {
                case "+":
                    vastus = sisend1 + sisend2;
                    Console.WriteLine(vastus);
                    break;

                case "-":
                    vastus = sisend1 - sisend2;
                    Console.WriteLine(vastus);
                    break;
                case "*":
                    vastus = sisend1 * sisend2;
                    Console.WriteLine(vastus);
                    break;
                case "/":
                    vastus = sisend1 / sisend2;
                    Console.WriteLine(vastus);
                    break;
                case "%":
                    vastus = sisend1 % sisend2;
                    Console.WriteLine(vastus);
                    break;


            }

            Console.ReadKey();
            Console.WriteLine("Vajuta klahviu et lõpetada programm.");


            // tegin oma esimese tutvuse funktsioonidega:
            double SetNumber(string outputText)
            {
                double parse;
                Console.Write(outputText);
                string tempInput = Console.ReadLine();
                while (!double.TryParse(tempInput, out parse))
                {
                    Console.WriteLine("See polnud number!");
                    Console.Write(outputText);
                    tempInput = Console.ReadLine();
                }
                return double.Parse(tempInput);
            }

        }
    }
}

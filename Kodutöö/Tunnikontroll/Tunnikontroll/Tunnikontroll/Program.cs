﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tunnikontroll
{
    class Program
    {
        static void Main(string[] args)
        {

            double sisend1;
            double tavaklient;
            double pysiklient;
            double Pmakse;
            double Tmakse;


            sisend1 = SetNumber("Kirjuta siia ostusumma: \n");

            if (sisend1 < 250 && sisend1 >= 50)
            {
                tavaklient = (sisend1 / 100 * 10);
                Tmakse = sisend1 - tavaklient;
                pysiklient = (sisend1 / 100 * 20);
                Pmakse = sisend1 - pysiklient;
                Console.WriteLine($"Tavakliendi allahindlus on 10% ja püsikliendi allahindlus on 20%");
                Console.WriteLine($"Tasuda on vaja tavakliendil {Tmakse} eurot püsikliendil {Pmakse} eurot ");
                Console.ReadKey();
            }

            else if (sisend1 < 350 && sisend1 >= 250)
            {
                tavaklient = (sisend1 / 100 * 20);
                Tmakse = sisend1 - tavaklient;
                pysiklient = (sisend1 / 100 * 30);
                Pmakse = sisend1 - pysiklient;
                Console.WriteLine($"Tavakliendi allahindlus on 20% ja püsikliendi allahindlus on 30%");
                Console.WriteLine($"Tasuda on vaja tavakliendil {Tmakse} eurot püsikliendil {Pmakse} eurot ");
                Console.ReadKey();
            }

            else if (sisend1 >= 350)
            {
                tavaklient = (sisend1 / 100 * 30);
                Tmakse = sisend1 - tavaklient;
                pysiklient = (sisend1 / 100 * 40);
                Pmakse = sisend1 - pysiklient;
                Console.WriteLine($"Tavakliendi allahindlus on 30% ja püsikliendi allahindlus on 40%");
                Console.WriteLine($"Tasuda on vaja tavakliendil {Tmakse} eurot püsikliendil {Pmakse} eurot ");
                Console.ReadKey();
            }

            else
            {
                Console.WriteLine("Allahindlus puudub");
                Console.ReadKey();
            }


            double SetNumber(string outputText)
            {
                double parse;
                Console.Write(outputText);
                string tempInput = Console.ReadLine();
                while (!double.TryParse(tempInput, out parse))
                {
                    Console.WriteLine("See polnud number, kirjuta number");
                    Console.Write(outputText);
                    tempInput = Console.ReadLine();
                }
                return double.Parse(tempInput);
            }

        }
    }
}

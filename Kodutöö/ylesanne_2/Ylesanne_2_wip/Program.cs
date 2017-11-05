﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ylesanne_2
{
    class Program
    {
        static void Main(string[] args)
        {

            Random rnd = new Random();
            int randomNumber = rnd.Next(100);
            int inputNumber = 0;
            // lisatud counter:
            int attempts = 0;
            Console.Write("Paku number ühest sajani: ");


            while (inputNumber != randomNumber)
            {
                string data = Console.ReadLine();
                inputNumber = int.Parse(data);


                if (randomNumber < inputNumber)
                {
                    Console.WriteLine("Sinu number on suurem, kui arvutil, paku uus number: ");
                    attempts++;
                }

                else if (randomNumber > inputNumber)
                {
                    Console.WriteLine("Sinu number on väiksem, kui arvutil, paku uus number: ");
                    attempts++;
                }

                else if (inputNumber > 100)
                {
                    Console.WriteLine("Pakkusid liiga suure numbri, paku palun number ühest sajani: ");
                    attempts++;
                }

                else if (inputNumber < 0)
                {
                    Console.WriteLine("");
                }

                if (randomNumber == inputNumber)
                {
                    Console.WriteLine($"Võit, vastus oligi: {randomNumber}, pidid pakkuma ainult {attempts} numbrit.");
                    Console.WriteLine("Nüüd tagasi progemise juurde.");
                    // avab veebilehe:
                    Console.ReadKey();
                    Process.Start("http://www.stackoverflow.com");
                    break;
                }
            }

            Console.ReadKey();
        }



    }

}























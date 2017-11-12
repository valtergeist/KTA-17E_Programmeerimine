using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {

        static void Main(string[] args)
        {
            Random rand = new Random();
            int inputNumber = 0;
            string begin = "Paku number ühest sajani: ";
            int randomNumber = rand.Next(1, 100);
            Console.WriteLine(begin);

            // lihtustatud counter, et teada mitu korda arvati:
            int i = 0;

            // Põhiline, mida õppisin on try-catch blocki kasutus, minu jaoks on antud programm pikema eksperimnteerimise tulemus.
            // Proovisin kasutada ka int.TryParse funktsiooni koos switchiga
            // Eesmärgiks oli input validation,juhuks kui ei sisalda numbrit:
            while (inputNumber != randomNumber)
            {
                try
                {
                    inputNumber = Convert.ToInt32(Console.ReadLine());

                    // sain teada et kui esimene condition on true, siis teiseni asi ei jõua nn. "short-circuit":
                    if (inputNumber > 100)
                    {
                        Console.WriteLine("Sisesta number ühest sajani, mitte suurem number ");
                    }

                    if (inputNumber > randomNumber && inputNumber > 101)
                    {
                        Console.WriteLine("Sinu number on suurem, kui arvutil, paku uus number: ");
                    }
                    
                    else
                    {
                        Console.WriteLine("Sinu number on väiksem, kui arvutil, paku uus number: ");
                        
                    }
                }

                catch
                {
                    Console.WriteLine("Palun sisestage numbriline väärtus!");
                    i--;
                }

                i++;
            }
            Console.WriteLine("Võit, sa pidid arvama arvasid " + i + " korda");
            // avab veebilehe:
            Console.ReadKey();
            Process.Start("http://www.stackoverflow.com");
            Console.ReadLine();
        }
    }
}
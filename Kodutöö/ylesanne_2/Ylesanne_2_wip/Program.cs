using System;
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
            string data = Console.ReadLine();
            while (!int.TryParse(data, out inputNumber))
            {
                Console.WriteLine("Palun sisestage numbriline väärtus!");
                Console.WriteLine("Paku number ühest sajani: ");
                break;
            }

            

            while (inputNumber != randomNumber)
            {
                

                if (randomNumber < inputNumber)
                {
                    Console.WriteLine("Sinu number on suurem, kui arvutil, paku uus number: ");
                    attempts++;
                    break;
                }

                else if (randomNumber > inputNumber)
                {
                    Console.WriteLine("Sinu number on väiksem, kui arvutil, paku uus number: ");
                    attempts++;
                    break;
                }

                else if (inputNumber > 100)
                {
                    Console.WriteLine("Pakkusid liiga suure numbri, paku palun number ühest sajani: ");
                    attempts++;
                    break;
                }

                else if (inputNumber < 0)
                {
                    Console.WriteLine("");
                    break;
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























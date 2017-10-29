using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ylesanne_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int randomNumber = rnd.Next(100);
            Console.Write("Paku uus number: ");
            int inputNumber = 0;

            while (inputNumber != randomNumber)
            {
                string sisend = Console.ReadLine();
                inputNumber = int.Parse(sisend);

                if (randomNumber < inputNumber)

                {
                    Console.WriteLine("Sinu number on suurem, kui arvutil, paku uus number: ");
                }

                if (randomNumber > inputNumber)
                {
                    Console.WriteLine("Sinu number on väiksem, kui arvutil, paku uus number: ");
                }

                if (randomNumber == inputNumber)
                {
                    Console.WriteLine($"Võit, vastus oligi: {randomNumber}");
                    break;
                }

            }
            Console.ReadKey();

        }
    }
}

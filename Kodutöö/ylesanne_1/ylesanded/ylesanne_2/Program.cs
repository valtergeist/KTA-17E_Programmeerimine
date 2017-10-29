using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ylesanne_2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int randomNumber = 25;


            Console.Write("Palun sisesta teine number: ");
            string sisend = Console.ReadLine();
            int inputNumber = int.Parse(sisend);

           while (randomNumber < inputNumber)
            {
                Console.WriteLine($"Sinu number on suurem, sest arvuti andis {randomNumber}, aga sina pakkusid {inputNumber}");
            }

            if (randomNumber > inputNumber)
            {
                Console.WriteLine($"Sinu number on väiksem, sest arvuti andis {randomNumber}, aga sina pakkusid {inputNumber}");
            }

            else if (randomNumber == inputNumber)
            {
                Console.WriteLine($"Sinu number on täpselt sama, sest arvuti andis {randomNumber}, aga sina pakkusid {inputNumber}");
            }


            Console.ReadKey();

        }
    }
}

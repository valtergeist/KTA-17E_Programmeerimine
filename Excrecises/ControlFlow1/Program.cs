using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ControlFlow1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Random rnd = new Random();
            int randomNumber = rnd.Next(100);

            
            Console.Write("Palun sisesta teine number: ");
            string sisend = Console.ReadLine();
            int inputNumber = int.Parse(sisend);



            if (randomNumber < inputNumber){
                Console.WriteLine($"Sinu number on suurem, sest arvuti andis {randomNumber}, aga sina pakkusid {inputNumber}" );
            }

            if (randomNumber > inputNumber){
                Console.WriteLine($"Sinu number on väiksem, sest arvuti andis {randomNumber}, aga sina pakkusid {inputNumber}");
            }

            else if (randomNumber == inputNumber){
                Console.WriteLine($"Sinu number on täpselt sama, sest arvuti andis {randomNumber}, aga sina pakkusid {inputNumber}");
            }
        

            Console.ReadKey();

        }
    }
}

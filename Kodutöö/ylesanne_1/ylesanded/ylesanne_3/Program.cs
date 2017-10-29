using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ylesanne_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int randomNumber = rnd.Next(100);
            

            Console.Write("Paku number: ");
            string sisend = Console.ReadLine();
            int inputNumber = int.Parse(sisend);

            { 
                if (randomNumber < inputNumber)
                {
                    Console.WriteLine("Sinu number on suurem, kui arvutil, paku uus number: ");
                    Console.ReadLine();
                }
            

                else if(randomNumber > inputNumber)
                {
                    Console.WriteLine("Sinu number on väiksem, kui arvutil, paku uus number: ");
                    Console.ReadLine();

                }

             

            Console.WriteLine($"Võit, vastus oli: {randomNumber}");
            Console.ReadKey();

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsimeneKalkulaator
{
    class Program
    {
        static void Main(string[] args)
        {
         Console.WriteLine("Mina olen kalkulaator");
            Console.WriteLine();

            Console.Write("Palun sisesta esimene number: ");
            string sisend1 = Console.ReadLine();
            int sisendNumber1 = int.Parse(sisend1);
            
            Console.Write("Palun sisesta teine number: ");
            string sisend2 = Console.ReadLine();
            int sisendNumber2 = int.Parse(sisend2);

            int vastus = sisendNumber1 + sisendNumber2;

            Console.WriteLine();
            Console.WriteLine("Tulemuseks on: " + vastus);

            Console.ReadKey();


        }
    }
}

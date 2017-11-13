using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6x6table
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----------------------------------");
            for (int i = 0; i < 7; i++)
            {
                Console.Write(" " + i);
                for (int j = 0; j < 7; j++)
                    {
                        if (i > 0)
                        Console.WriteLine($"{i*j}|{i * j}|{i * j}|{i * j}|{i * j}|{i * j}");
                    }


         
                Console.ReadKey();
            }
            Console.WriteLine("----------------------------------");
        }
    }
}

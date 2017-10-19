using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First_User_Input
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mina ütlen: midagi");
            Console.WriteLine();
            string sisend ="";
            Console.Write("Sina ütled: " + sisend);
            sisend = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        }




    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //declaring a simple array:
            string[] months = { "Jaanuar", "Veebruar", "Märts", "Aprill", "Mai", "Juuni", "Juuli", "August", "September", "November", "Detsember"};


            //decalring a multidimensional array: the following declaration creates a two-dimensional array of two rows and 4 columns
            int[,] array = new int[2, 4];

            Console.WriteLine(String.Join("\n", months));
            Console.ReadKey();

            // replacing an element:
            months[1] = "veebruar";

            Console.WriteLine(String.Join("\n", kuud));
            Console.ReadKey();

           

        }
    }
}

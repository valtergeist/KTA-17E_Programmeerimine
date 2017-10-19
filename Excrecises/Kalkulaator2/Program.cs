using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalkulaator2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mina olen teine kalkulaator");
            Console.WriteLine();

            Console.Write("Palun sisesta esimene number: ");
            string sisend1 = Console.ReadLine();
            float sisendNumber1 = float.Parse(sisend1);

            Console.Write("Palun sisesta teine number: ");
            string sisend2 = Console.ReadLine();
            float sisendNumber2 = float.Parse(sisend2);

            float vastus1 = sisendNumber1 * sisendNumber2;
            float vastus2 = sisendNumber1 / sisendNumber2;

            Console.WriteLine();
            Console.WriteLine($"Korrutades {sisendNumber1} ja  {sisendNumber2} on tulemuseks: {vastus1}");
            Console.WriteLine($"Jagades {sisendNumber1} ja {sisendNumber2} on tulemuseks: {vastus2}");
            Console.WriteLine();

            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcuseGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            // array string splitg
            // vabanduste geneeririmise programnm
            // sisesta komadega eraldatud vabandused
            // kasutaja sisend
            // täanne vabandus: ei viitsinud


            Console.WriteLine("VABANDUSTE VALIMISE PROGRAMM");
            Console.WriteLine("Palun sisesta vabandused mille vahel valida, eralda komadega ");
            Console.WriteLine("Sisesta vabandused: ");
            string sisend = Console.ReadLine();

            //string[] stringVabandused = new string[5];

            string[] stringVabandused = sisend.Split(',');

            int random = new Random().Next(0, stringVabandused.Length);


            Console.WriteLine($"Tänane vabandus on: {stringVabandused[random]}");
            Console.ReadKey();
        

        }
    }
}

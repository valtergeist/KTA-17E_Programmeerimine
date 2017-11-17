using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new [] {3, 7, 9, 78, 117, 02, 32};

            // Lentgh

            Console.WriteLine("The length of the array is: " + numbers.Length);
            

            // IndexOf()

            var index = Array.IndexOf(numbers, 9);
            Console.WriteLine("The index of number 9 is: " + index);
            Console.ReadKey();

            // Clear()
            Array.Clear(numbers,3, 2);
            Console.WriteLine("The effect of Clear():");
            foreach (var n in numbers)
                Console.WriteLine(n);
            

            // Copy()
            int[] another = new int[3];
            Array.Copy(numbers, another, 3);
            Console.WriteLine("The effect of Copy():");
            foreach (var n in another)
                Console.WriteLine(n);
            Console.ReadKey();


            //Sort()
            Array.Sort(numbers);
            Console.WriteLine("The effect of Sort():");
            foreach (var n in numbers)
                Console.WriteLine(n);
            Console.ReadKey();

            //Reverse()
            Array.Reverse(numbers);
            Console.WriteLine("The effect of Reverse():");
            foreach (var n in numbers)
                Console.WriteLine(n);
            Console.ReadKey();

        }
    }
}

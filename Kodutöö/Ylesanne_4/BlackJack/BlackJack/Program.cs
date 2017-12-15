﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the game of Blackjack!");
            Console.WriteLine();

            Console.WriteLine("You have been dealt: 4C, 6H");
            Console.WriteLine("House has been dealt: 8S, [?]");
            Console.WriteLine();

            Console.WriteLine("What do you want to do?");
            Console.WriteLine("Choose: 1 - To take another card");
            Console.WriteLine("Choose: 2 - To finish");
            Console.WriteLine();
            Console.WriteLine("I choose: 1");
            Console.WriteLine();

            Console.WriteLine("You have been dealt: 4S");
            Console.WriteLine("House has been dealt: [?]");
            Console.WriteLine();

            Console.WriteLine("What do you want to do?");
            Console.WriteLine("Choose: 1 - To take another card");
            Console.WriteLine("Choose: 2 - To finish");
            Console.WriteLine();
            Console.WriteLine("I choose: 2");
            Console.WriteLine();

            Console.WriteLine("You have 14 points vs. house 17 points");
            Console.WriteLine("House wins!");

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Press any key");
            Console.ReadKey();
        }
    }
}

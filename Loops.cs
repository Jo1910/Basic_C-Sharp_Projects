﻿using System;


namespace Loops
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Guess a number?");
            int number = Convert.ToInt32(Console.ReadLine());

            switch (number)
            {
                case 62:
                    Console.WriteLine("You guessed 62. Try again");
                    break;
                case 29:
                    Console.WriteLine("You guessed 29. Try again");
                    break;
                case 55:
                    Console.WriteLine("you guessed 55. Try again");
                    break;
                case 12:
                    Console.WriteLine("You guessed the number 12. That is correct!");
                    break;
                default:
                    Console.WriteLine("You are wrong.");
                    break;
            }
            Console.Read();
        }
    }
}

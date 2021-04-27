using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatingProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculating...");
            Console.WriteLine("-----------------\n");

            Console.WriteLine("Please enter a number:");
            int userNum1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter a second number:");
            int userNum2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Choose an option from the following list:");
            Console.WriteLine("\ta - Add");
            Console.WriteLine("\ts - Subtract");
            Console.WriteLine("\tm - Multiply");

            switch (Console.ReadLine())
                {
                case "a":
                    Console.WriteLine(userNum1 + userNum2);
                    break;
                case "s":
                    Console.WriteLine(userNum1 - userNum2);
                    break;
                case "m":
                    Console.WriteLine(userNum1 * userNum2);
                    break;

            }
            Console.ReadLine();

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodAssign2
{
    class Program
    {
        static void Main(string[] args)
        {
            Math math = new Math(); //instantiating the class

            // Asking the user to input the numbers, one at a time and letting them know
            // they need not entering anything for the second number
            Console.WriteLine("\nPlease enter a number.");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nPlease enter a second number, if you wish (it is optional).");
            string b = Console.ReadLine();
            bool inputFound = string.IsNullOrEmpty(b); // creating a boolean set to return true if the string b is null or has no data.
            
            // displaying results by calling the method in the class, passing in one or two numbers entered
            if (inputFound == false) { 
                int x = Convert.ToInt32(b);
                Console.WriteLine("\n\tThe sum of " + a + " and " + x + ", multiplied by 10, equals " + math.mathOp(a, x) + ".");
            }
            else
            {
                Console.WriteLine("\n\tThe sum of " + a + " and " + "our optional number (6)" + ", multiplied by 10, equals " + math.mathOp(a) + ".");

            }

            Console.ReadLine();
        }
    }
}

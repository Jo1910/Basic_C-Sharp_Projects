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
            Math math = new Math();

            Console.WriteLine("\nPlease enter a number.");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nPlease enter a second number, if you wish (it is optional).");
            string b = Console.ReadLine();
            bool inputFound = string.IsNullOrEmpty(b);
            

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

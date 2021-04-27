using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number:");
            int userNum = Convert.ToInt32(Console.ReadLine());

            Math math = new Math();

            Console.WriteLine("\n" + userNum + " + 156 " + " equals " + math.addNumbers(userNum));
            Console.WriteLine("\n" + userNum + " * 233 " + " equals " + math.multNumbers(userNum));
            Console.WriteLine("\n" + userNum + " - 8 " + " equals " + math.subNumbers(userNum));

            Console.ReadLine();
        }
        
    }
    
}

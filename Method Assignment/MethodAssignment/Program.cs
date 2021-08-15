using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// The assignment is to create a class and in that class to create three method, each of which will take one parameter
// in and return an integer. The methods should do some math operation on the received parameter.

namespace MethodAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number:"); // asking for user input
            int userNum = Convert.ToInt32(Console.ReadLine());

            Math math = new Math(); //instantiating the class Math

            Console.WriteLine("\n" + userNum + " + 156 " + " equals " + math.addNumbers(userNum));
            Console.WriteLine("\n" + userNum + " * 233 " + " equals " + math.multNumbers(userNum));
            Console.WriteLine("\n" + userNum + " - 8 " + " equals " + math.subNumbers(userNum));

            Console.ReadLine();
        }
        
    }
    
}

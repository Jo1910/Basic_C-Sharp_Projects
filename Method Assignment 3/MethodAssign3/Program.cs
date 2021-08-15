using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// ---- The assignment is to create a class with a void method that takes in two integers as parameters. 
// ---- Then have a method do a math operation on the first integer and display a second integer to the screen, 
// ---- To call a method in the class passing in two numbers, and to call it again specifying the parameters by name.

namespace MethodAssign3
{
    class Program
    {
        static void Main(string[] args)
        {
            MathOper showNum = new MathOper();
            showNum.Math(4, 5);
            showNum.Math(num1: 4, num2: 3);
        }
    }
}

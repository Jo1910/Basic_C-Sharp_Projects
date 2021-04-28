using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethodAssign
{
    static class MathOp
    {
        public static void divideNum(int userNum)
        {
            int result = userNum / 2;
            Console.WriteLine("\n\t" + userNum + " divided by 2 equals " + result);
        }

        public static void addNum(out int x, out int y) // creating a method with output parameters
        {
            x = 15;
            y = 20;

            Console.WriteLine("\n\t" + x + " + " + y + " equals " + (x + y));
        }

        public static void addNum(out double a, out double b)      // overloading a method
        {
            a = 4.6;
            b = 5.8;

            Console.WriteLine("\n\t" + a + " + " + b + " equals " + (a + b));
        }
    }
}

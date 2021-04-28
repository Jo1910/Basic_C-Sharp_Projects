using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

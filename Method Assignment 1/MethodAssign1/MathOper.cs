using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodAssign1
{
    class MathOper //creating class "MathOper"
    {
        public int mathOperation(int num1)  // creating a method that will take in integer as a parameter
        {
            return num1 + 13;
        }

        public int mathOperation(decimal num2) // creating a method with the same name, different parameter
        {
            return Convert.ToInt32(num2) + 20;
        }
        
        public int mathOperation(string num3) // creating a method with the same name, different parameter
        {
            return Convert.ToInt32(num3) * 40;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodAssign2
{
    class Math //creating a class that takes in 2 integers as parameters, one of them is optional - it has a default value
    {
        public int mathOp(int userNum, int optNum = 6)
        {
            return ((userNum + optNum) * 10);
        }
    }
}

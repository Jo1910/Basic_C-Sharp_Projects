using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodAssign2
{
    class Math
    {
        public int mathOp(int userNum, int optNum = 6)
        {
            return ((userNum + optNum) * 10);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructsAssign
{
    class Program
    {
        public struct Number
        {
            public decimal Amount { get; set; }
        }

        static void Main(string[] args)
        {
            Number n = new Number();
            n.Amount = 134.567m;
            Console.WriteLine("The amount is " + n.Amount);
            Console.ReadLine();
        }
    }
}

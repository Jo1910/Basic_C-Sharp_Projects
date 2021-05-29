using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructsAssign
{
    class Program
    {
        public struct Number // creating a struct and giving it a property
        {
            public decimal Amount { get; set; }
        }

        static void Main(string[] args)
        {
            Number n = new Number(); // creating an object of data type "Number"
            n.Amount = 134.567m;
            Console.WriteLine("The amount is " + n.Amount);
            Console.ReadLine();
        }
    }
}

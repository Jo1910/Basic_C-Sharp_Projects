using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace IOassign
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number:");
            string number = Console.ReadLine();
            File.WriteAllText(@"C:\Users\mitic\Documents\io.txt", number);
            Console.WriteLine("The number you chose is " + File.ReadAllText(@"C:\Users\mitic\Documents\io.txt") + ".");
            Console.ReadLine();

        }
    }
}

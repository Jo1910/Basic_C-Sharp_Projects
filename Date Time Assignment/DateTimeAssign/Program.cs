using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeAssign
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime timeNow = DateTime.Now;
            Console.WriteLine("The current date and time is: " + timeNow);
            Console.WriteLine("Please enter a number:");
            int X = Convert.ToInt32(Console.ReadLine());
            DateTime timeFuture = timeNow.AddHours(X);
            Console.WriteLine("In " + X+ " hours it will be " + timeFuture + ".");
            Console.ReadLine();

        }
    }
}

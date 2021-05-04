using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumAssign
{
    class Program
    {
        enum weekDays   // creating an enum for the days of the week
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Please enter the current day of the week."); // prompting the user to enter the current day
                weekDays day = (weekDays)Enum.Parse(typeof(weekDays), Console.ReadLine()); // assigning the value to a variable of the enum data type created
                Console.WriteLine("Thank you. Today is " + day + ".");
                Console.ReadLine();
            }
            catch
            {
                Console.WriteLine("Please enter an actual day of the week.");
                Console.ReadLine();
            }
             
        }
    }
}

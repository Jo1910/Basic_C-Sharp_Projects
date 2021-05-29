using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionAssign
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your age:");
            try
            {
                bool validAnswer = false;
                int age = 0;
                while (!validAnswer)
                {
                    validAnswer = int.TryParse(Console.ReadLine(), out age);
                    if (!validAnswer) Console.WriteLine("Please enter digits only, no decimals.");
                }
                if (age < 0)
                {
                    throw new AgeException();
                }
                DateTime yearNow = DateTime.Now;
                int x = Convert.ToInt32(yearNow.Year);
                int birthYear = x - age;
                Console.WriteLine("Your birth year was {0}", birthYear + ".");
                Console.ReadLine();
            }
            catch (AgeException)
            {
                Console.WriteLine("An error occurred. Please enter positive digitals only, no decimals.");
                Console.ReadLine();
                return;
            }
            catch (Exception)
            {
                Console.WriteLine("An error occurred. Please contact your system administrator.");
                Console.ReadLine();
                return;
            }

          
 
        }
    }
}

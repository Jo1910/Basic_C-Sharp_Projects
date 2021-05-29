using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionAssignment
{
    class Program
    {
        static void Main()
        {
            try
            {
                List<int> numbers = new List<int>() { 16, 23, 77, 82, 19, 34, 55 };
                Console.WriteLine("Please enter a number:");
                int userNum = Convert.ToInt32(Console.ReadLine());

                foreach (int number in numbers)
                {
                    int result = number / userNum;
                    Console.WriteLine(result);
                }
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Please enter a whole number.");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Please don't divide by zero.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.ReadLine();
            }

            

            Console.WriteLine("Please press enter to exit the program.");
            Console.ReadLine();
        }
    }   



}

using System;

namespace MathOperationAssignment
{
    class Program
    {
        static void Main()
        {   
            int num1, num2, num3, num4, num5, multNum, addNum; //declaring variables
            // takes an input from the user, multiplies it by 50 and prints the result to the console
            Console.WriteLine("Please enter a number:" + '\n');
            num1 = Convert.ToInt32(Console.ReadLine());
            multNum = num1 * 50;
            Console.WriteLine("The number you entered multiplied by 50 equals " + multNum.ToString() + "." + '\n' + '\n' + "Press enter to continue");
            Console.ReadLine();
           
            // takes an input from the user, adds 25 to it, and prints the result to the console
            Console.WriteLine("Please enter a number:" + '\n');
            num2 = Convert.ToInt32(Console.ReadLine());
            addNum = num2 + 25;
            Console.WriteLine("The number you entered added to 25 equals " + addNum.ToString() + "." + '\n' + '\n' + "Press enter to continue");
            Console.ReadLine();

            // takes an input from the user, divides it by 12.5, and prints the result to the console
            Console.WriteLine("Please enter a number:" + '\n');
            num3 = Convert.ToInt32(Console.ReadLine());
            double divNum = num3 / 12.5;
            Console.WriteLine("The number you entered divided by 12.5 equals " + divNum.ToString() + "." + '\n' + '\n' + "Press enter to continue");
            Console.ReadLine();

            // takes an input from the user, checks if it is greater than 50, and prints the true/false to the console
            Console.WriteLine("Please enter a number:" + '\n');
            num4 = Convert.ToInt32(Console.ReadLine());
            bool greaterThan = num4 > 50;
            Console.WriteLine(greaterThan + " Press enter to continue" + '\n');
            Console.ReadLine();

            // takes an input from the user, divides it by 7 and prints the remainder to the console
            Console.WriteLine("Please enter a number:" + '\n');
            num5 = Convert.ToInt32(Console.ReadLine());
            int remNum = num5 % 7;
            Console.WriteLine(remNum);
            Console.ReadLine();
        }
    }
}

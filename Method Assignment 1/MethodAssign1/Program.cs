using System;


namespace MethodAssign1
{
    class Program
    {
        static void Main(string[] args)
        {
            MathOper math = new MathOper(); // instantiating the class

            // Displaying the results to the screen
            Console.WriteLine("\n\t 13 + 13 equals " + math.mathOperation(13) + ".");
            Console.WriteLine("\n\t 20 + 3.4, rounded to the nearest integer, equals " + math.mathOperation(3.4m) + ".");
            Console.WriteLine("\n\t 20 * 50 equals " + math.mathOperation("50") + ".");
            Console.ReadLine();

        }
    }
}

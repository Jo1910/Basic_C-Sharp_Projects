using System;

namespace ClassMethodAssign
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number:\n");
            int userNum = Convert.ToInt32(Console.ReadLine());


            //MathOp math = new MathOp(); // instatiating the class "MathOp" (commented out because I declared 
                                          // the class "MathOp" to be static
            MathOp.divideNum(userNum);  // calling the method on the number entered by user
            Console.ReadLine(); // displaying the outpu to the screen

            // calling a method with output parameters
            int x;
            int y;
            MathOp.addNum(out x, out y);
            Console.ReadLine();

            // calling a overloaded method
            double a;
            double b;
            MathOp.addNum(out a, out b);
            Console.ReadLine();
        }

        
    }
}

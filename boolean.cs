using System;


namespace BooleanLogic
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("What is your age?");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Have you ever had a DUI violation?(yes/no)");
            string dui = Console.ReadLine();
            Console.WriteLine("How many speeding tickets have you had?");
            int tickets = Convert.ToInt32(Console.ReadLine());

            bool license = (age >= 15 && dui == "no" && tickets <= 3);
            Console.WriteLine(license);
            Console.ReadLine();

        }
    }
}

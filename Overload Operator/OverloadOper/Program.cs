using System;

namespace OverloadOper
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee(); // creating an instance of "Employee" class
            employee1.Id = 11;

            Employee employee2 = new Employee();
            employee2.Id = 13;


            Console.WriteLine(employee1.Equals(employee2)); // method equals checking the value equality between
                                                                // two objects
            Console.ReadLine();
            

            //// comparing and displaying using comparison operator

            //if (employee1.Id == employee2.Id)
            //{
            //    Console.WriteLine("Employees IDs are the same.");
            //}
            //else
            //{
            //    Console.WriteLine("Employees IDs are not the same");
            //}
            //Console.ReadLine();

        }

    }
}

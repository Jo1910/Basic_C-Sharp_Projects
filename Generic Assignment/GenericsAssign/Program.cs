using System;
using System.Collections.Generic;


namespace GenericsAssign
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee<string> employee = new Employee<string>(); // instatiating an Employee object with string type as its generic parameter
            employee.things = new List<string>() { "Dina", "Alen", "Maria", "Peter" }; // assigning a list of strings as the property value of things

            Employee<int> employeeAge = new Employee<int>(); // instatiating an Employee object with integer type as its generic parameter
            employeeAge.things = new List<int> { 22, 50, 33, 44 }; // assigning a list of integers as the property value of things

            //foreach (string emp in employee.things) // creating a loop that prints employees names
            //{
            //    Console.Write(emp + " " + '\n');
            //}
            //foreach (int age in employeeAge.things) // creating a loop that prints employees age
            //{
            //    Console.Write(age + " " +'\n');
            //}
            //Console.ReadLine();

            int i = 0;
            foreach (string emp in employee.things)  // loop that prints both lists
            {
                Console.WriteLine(emp + " " + employeeAge.things[i++]);
            }
            Console.ReadLine();

            


        }
    }
}

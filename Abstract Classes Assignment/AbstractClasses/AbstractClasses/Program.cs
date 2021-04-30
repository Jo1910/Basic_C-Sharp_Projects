using System;

namespace AbstractClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee(); //instatiating an Employee object and adding it properties
            employee.firstName = "Sample";       
            employee.lastName = "Student";
            employee.sayName();
            Console.ReadLine();
        }
    }
}

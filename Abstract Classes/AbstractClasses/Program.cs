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

            IQuittable iquitt = new Employee(); // creating an object of an interface referencing its child's class
            iquitt.Quit(); // calling the "Quit" method on the created object
            Console.ReadLine();

        }
    }
}

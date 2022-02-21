using System;

namespace InheritanceAssign
{
    class Program
    {
        static void Main(string[] args)
        {
            // instantiating and initializing an Employee object
            Employee employee = new Employee();
            employee.FirstName = "Sample";
            employee.LastName = "Student";

            employee.SayName();      // calling the superclass method "SayName on the Employee object
            Console.ReadLine();
        }
    }
}

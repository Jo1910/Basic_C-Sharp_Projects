using System;

namespace AbstractClasses
{
   class Employee : Person // creating a class "Employee" that inherits from "Person" class
    {
        public override void sayName()  // implementing the "sayName" method
        {
            Console.WriteLine("Name: " + firstName + " " + lastName); // displaying result
        }
    }
}

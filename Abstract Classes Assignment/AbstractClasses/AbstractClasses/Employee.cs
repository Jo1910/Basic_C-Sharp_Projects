﻿using System;

namespace AbstractClasses
{
   class Employee : Person, IQuittable // creating a class "Employee" that inherits from "Person" class,
                                       // class "Employee" inherits interface "IQuittable"
    {
        public override void sayName()  // implementing the "sayName" method
        {
            Console.WriteLine("Name: " + firstName + " " + lastName); // displaying result
        }
        public void Quit()  // implementing the method from interface
        {
            Console.WriteLine("This employee quits."); // Displaying to the console
        }
    }
}

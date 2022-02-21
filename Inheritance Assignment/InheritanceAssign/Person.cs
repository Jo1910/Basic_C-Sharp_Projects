using System;

namespace InheritanceAssign
{
    // Creating a class "Person" and giving it two properties and a void method
    // that simply writes the person's full name to the console.
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public void SayName()
        {
                Console.WriteLine("Name: " + FirstName + " " + LastName);
        }
    }
}


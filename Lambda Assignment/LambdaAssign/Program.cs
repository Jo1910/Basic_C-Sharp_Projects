using System;
using System.Collections.Generic;
using System.Linq;

namespace LambdaAssign
{
    class Program
    {
       
        static void Main(string[] args)
        {
            // Creating a list of employees.
            List<Employee> employees = new List<Employee>(); 

            employees.Add(new Employee { firstName = "Terri", lastName = "Daniels", Id = 4 });
            employees.Add(new Employee { firstName = "Joe", lastName = "Wicklow", Id = 8 });
            employees.Add(new Employee { firstName = "Woody", lastName = "Kay", Id = 7 });
            employees.Add(new Employee { firstName = "Joe", lastName = "Bluebell", Id = 12 });
            employees.Add(new Employee { firstName = "Alisha", lastName = "Busby", Id = 3 });
            employees.Add(new Employee { firstName = "Findlay", lastName = "Greeney", Id = 24 });
            employees.Add(new Employee { firstName = "Matei", lastName = "Sneider", Id = 18});
            employees.Add(new Employee { firstName = "Isaak", lastName = "Povei", Id = 6});
            employees.Add(new Employee { firstName = "Andreaa", lastName = "Hodge", Id = 13 });
            employees.Add(new Employee { firstName = "Haleema", lastName = "Beck", Id = 33});
            employees.Add(new Employee { firstName = "Joe", lastName = "Kirk", Id = 2 });
            employees.Add(new Employee { firstName = "Delia", lastName = "Velez", Id = 19 });
            employees.Add(new Employee { firstName = "Cem", lastName = "McMillan", Id = 38 });


            List<Employee> joeList = new List<Employee>();

            // Creating a new list of all employees with the first name "Joe", using a foreach loop.
            foreach (Employee e in employees)
            {
                if (e.firstName == "Joe")
                {
                    joeList.Add(e);
                    Console.WriteLine(e.firstName + " " + e.lastName + '\n');
                }
            }

            Console.WriteLine();

            // Performing the same action using a lambda expression.
            List<Employee> joeList1 = employees.Where(x => x.firstName == "Joe").ToList();
            foreach (Employee e in joeList1)
            {
                Console.WriteLine(e.firstName + " " + e.lastName + '\n');
            }

            // Making a list of all employees with an ID number greater than 5.
            List<Employee> joeList2 = employees.Where(x => x.Id > 5).ToList();
            foreach (Employee e in joeList2)
            {
                Console.WriteLine("The employee " + e.firstName + " " + e.lastName + " has an ID " + e.Id + ".");
            }
            Console.ReadLine();

        }

    }
}

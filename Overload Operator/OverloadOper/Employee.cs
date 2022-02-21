using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadOper
{
    public class Employee // creating a class called "Employee"
    { 
      public int Id { get; set; } // giving it a property "Id" of integer type


    //// comparing two objects using comparison operator overloading
    
    
    //public static bool operator == (Employee employee1, Employee employee2)
    //{
    //    if (employee1.Id == employee2.Id)
    //    {
    //        return true;
    //    }
    //    else
    //    {
    //        return false;
    //    }
    //}

    //public static bool operator != (Employee employee1, Employee employee2)
    //{
    //    if (employee1.Id != employee2.Id)
    //    {
    //        return true;
    //    }
    //    else
    //    {
    //        return false;
    //    }
    //}

   
    public override bool Equals(object obj) // overriding the equals method in order to test for value equality
     {
        if (obj == null) // checking that argument is not null
        {
           return false;
        }
        if (!(obj is Employee)) // if the passed in object is not "Employee" type or can't be referenced to it, return false
        {
           return false;
        }
           return this.Id == ((Employee)obj).Id; // checking if passed in object Id is equal to this instance of Id
        }
        public override int GetHashCode() // overriding the hash method to allow a type to work correctly in a hash table
        {
          return this.Id.GetHashCode();
     }

    }   
}

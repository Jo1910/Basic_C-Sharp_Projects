using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses
{
    public abstract class Person  // creating an abstract class "Person"
    {
        public string firstName { get; set; } // creating two properties of the class
        public string lastName { get; set; }

        public abstract void sayName();  // giving it a method "sayName"
        
    }
}

using System;
using System.Collections.Generic;

namespace GenericsAssign
{
    public class Employee<T> // creating the "Employee" class that takes generic type parameter
    {
        public List<T> things { get; set; } //adding a property called "things" with generic list as a data type

    }
}

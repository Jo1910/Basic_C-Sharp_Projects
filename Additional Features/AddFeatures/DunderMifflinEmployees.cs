using System;


namespace AddFeatures
{
    class DunderMifflinEmployees
    {
        string firstName;
        string lastName;
        string occupation;

        // Chaining two constructors together / overloading constructor.
        public DunderMifflinEmployees() : this("Michael", "Scott", "the regional manager")
        {

        }

        public DunderMifflinEmployees(string firstName, string lastName, string occupation)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.occupation = occupation;
        }

        public void employeeIs()
        {
            Console.WriteLine(firstName + " " + lastName + " is " + occupation + ".");
        }
   
    

    }
}

using System;


namespace AddFeatures
{
    class Program
    {
        static void Main()
        {
            const string company = "Dunder Mifflin Paper Co.";
            Console.WriteLine("Welcome to {0}", company);
          

            DunderMifflinEmployees employee = new DunderMifflinEmployees();
            employee.employeeIs();
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncomeComparison
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Anonymous Income Comparison Project" + '\n' + '\n' + "Press enter to continue");
            Console.ReadLine();
              Console.WriteLine("Person 1" + '\n' + '\n' + "Press enter to continue:");
              Console.ReadLine();
              Console.WriteLine("Please enter your hourly rate:");
              int hrRate1 = Convert.ToInt32(Console.ReadLine());
              Console.WriteLine("Please enter how many hours you work per week:");
              int wHours1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Person 2" + '\n' + '\n' + "Press enter to continue:");
                Console.ReadLine();
                Console.WriteLine("Please enter your hourly rate:");
                int hrRate2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please enter how many hours you work per week:");
                int wHours2 = Convert.ToInt32(Console.ReadLine());

                // Annual salary of Person 1
                Console.WriteLine("Annual salary of Person 1:" + '\n');
                int annSalary1 = (hrRate1 * wHours1) * 52;
                Console.Write(annSalary1);
                Console.ReadLine();
                
                // Annual salary of Person 2
                Console.WriteLine("Annual salary of Person 2:" + '\n');
                int annSalary2 = (hrRate2 * wHours2) * 52;
                Console.Write(annSalary2);
                Console.ReadLine();

                  // Compare two salaries
                  Console.WriteLine("Person 1 makes more money than Person 2.");
                  bool compSalaries = annSalary1 > annSalary2;
                  Console.Write(compSalaries);
                  Console.ReadLine();
                  

                


        }
    }
}
